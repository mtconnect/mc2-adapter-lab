#include <stdio.h>
#ifdef _WIN32
#include <windows.h>
#else
#include <sys/socket.h>
#include <sys/select.h>
#include <stdlib.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <netdb.h>
#include <time.h>
#include <unistd.h>
#endif

#include <sys/types.h>
#include <string.h>

#define PORT        7878
#define HOST        "localhost"
#define BUFFER_SIZE 1024

#ifndef _WIN32
#define SOCKET int
#define closesocket close
#endif

void cleanup_and_exit(int ret)
{
#ifdef _WIN32
  WSACleanup();
#endif
  exit(ret);
}

void usage()
{
  fprintf(stderr, "Usage: dump [-t timeout] [host] [port] [file]\n    host defaults to localhost\n    port defaults to 7878\n    file defaults to stdout\n");
  exit(0);
}

int main(int argc, char **argv)
{
  char hostname[100];
  SOCKET  sd;
  struct sockaddr_in pin;
  struct hostent *hp;
  char buffer[BUFFER_SIZE];
  int port;
  FILE *file;
  char dump = 0;
  char **argvp = argv;
  time_t start = 0;
  int remaining = 1, timeout = 0, nfds;
  struct fd_set fds;
  struct timeval tv, *tvp = 0;
  
#ifdef _WIN32
  WSADATA wsaData;
  if (WSAStartup(MAKEWORD(2,0), &wsaData) != 0) {
    fprintf(stderr, "WSAStartup failed\n");
    cleanup_and_exit(1);
  }
#endif
  
  if (argc > 1) {
    if (strcmp(argv[1], "-h") == 0) {
      usage();
    } else if (strcmp(argv[1], "-t") == 0) {
      if (argc < 3) {
        fprintf(stderr, "Missing timeout argument\n");
        usage();
      }
      timeout = atoi(argv[2]);
      argc -= 2;
      argvp += 2;
    }    
  }
  
  strcpy(hostname,HOST);
  if (argc > 1) { 
    strcpy(hostname,argvp[1]); 
  }
    
  port = PORT;
  if (argc > 2) {
    port = atoi(argvp[2]);
  }

  file = stdout;
  if (argc > 3) {
    file = fopen(argvp[3], "w");
    if (file == NULL) {
      perror("fopen");
      fprintf(stderr, "Cannot open file %s\n", argv[3]);
      exit(1);
    }
    dump = 1;
  }

  /* go find out about the desired host machine */
  if ((hp = gethostbyname(hostname)) == (void*) 0) {
    perror("gethostbyname");
    cleanup_and_exit(1);
  }

  /* fill in the socket structure with host information */
  memset(&pin, 0, sizeof(pin));
  pin.sin_family = AF_INET;
  memcpy(&pin.sin_addr.s_addr, hp->h_addr, hp->h_length);
  pin.sin_port = htons(port);

  /* grab an Internet domain socket */
  if ((sd = socket(AF_INET, SOCK_STREAM, 0)) == -1) {
    perror("socket");
    cleanup_and_exit(1);
  }

  /* connect to PORT on HOST */
  if (connect(sd,(struct sockaddr *)  &pin, sizeof(pin)) == -1) {
    perror("connect");
    cleanup_and_exit(1);
  }
  
  if (dump) {
    printf("Connected to %s port %d\n", hostname, port);
  }
  
  /* wait for a message to come back from the server */
  if (timeout > 0) {
    start = time(0);
    remaining = timeout;
    tv.tv_usec = 0;
    tvp = &tv;
  }
#ifdef _WIN32
  nfds = 1;
#else
  nfds = sd + 1;
#endif
  while (remaining > 0) {
    int n;

    FD_ZERO(&fds);
    FD_SET(sd, &fds);
    tv.tv_sec = remaining;    
    n = select(nfds, &fds, (fd_set*) 0, (fd_set*) 0, tvp);
    if (n < 0) {
      closesocket(sd);
      perror("recv");
      cleanup_and_exit(1);      
    } else if (n > 0) {
      int count = recv(sd, buffer, BUFFER_SIZE, 0);
      if (count == -1) {
        closesocket(sd);
        perror("recv");
        cleanup_and_exit(1);
      }
      if (count == 0)
        break;
      fwrite(buffer, 1, count, file);
      if (dump) {
        fputc('.', stdout);
        fflush(stdout);
      }
      fflush(file);
    }    
    
    if (timeout > 0) {
      time_t now = time(0);
      remaining -= (int) (now - start);
      start = now;
    }
  }
  
  if (dump) printf("\nFinished\n");
  
  fclose(file);
  closesocket(sd);
#ifdef _WIN32
  WSACleanup();
#endif
  
  return 0;
}
