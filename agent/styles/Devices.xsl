<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:fn="http://www.w3.org/2005/xpath-functions" xmlns:m="urn:mtconnect.org:MTConnectDevices:1.3" >
	<xsl:output method="html" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:template match="/">
			<head>
				<title>MTConnect Device Streams</title>
				<link type="text/css" href="/styles/Devices.css" media="screen" rel="stylesheet"/>
			</head>
			<body>
				<p>
					<xsl:apply-templates select="/m:MTConnectDevices/m:Header" />
				</p>
				<hr/>
				<xsl:apply-templates select="/m:MTConnectDevices/m:Devices/m:Device" />
			</body>
	</xsl:template>
	
	<xsl:template match="m:Device">
		<h2>Device: <xsl:value-of select="@name"/>
		<xsl:text>; UUID: </xsl:text><xsl:value-of select="@uuid"/>
		</h2>
		<xsl:apply-templates select="m:Description"/>
		<xsl:apply-templates select="m:DataItems"/>
		<xsl:apply-templates select="m:Components">
			<xsl:with-param name="depth" select="1" />
		</xsl:apply-templates>
	</xsl:template>
	
	<xsl:template match="m:Header">
		<ul>
			<xsl:for-each select="@*">
				<li>
					<xsl:value-of select="name()"/>
					<xsl:text>: </xsl:text>
					<xsl:value-of select="." />
				</li>
			</xsl:for-each>
		</ul>
	</xsl:template>
	
	<xsl:template match="m:Description">
		<ul>
			<xsl:for-each select="@*">
				<li>
					<xsl:value-of select="name()"/>
					<xsl:text>: </xsl:text>
					<xsl:value-of select="." />
				</li>
			</xsl:for-each>
			<li><xsl:value-of select="text()"/></li>
		</ul>		
	</xsl:template>
	
	<xsl:template match="m:DataItems">
		<table class="data-item">
			<thead>
				<tr><th>Category</th><th>Type</th><th>Sub Type</th><th>Id</th><th>Name</th>
					 <th>Units</th><th>Native Units</th><th>Representation</th><th>Sample Rate</th><th>Native Scale</th><th>Statistic</th></tr>
			</thead>
			<tbody>				
				<xsl:for-each select="./m:DataItem">
					<tr>
						<td><xsl:value-of select="@category" /></td>
						<td><xsl:value-of select="@type" /></td>
						<td><xsl:value-of select="@subType" /></td>
						<td><xsl:value-of select="@id" /></td>
						<td><xsl:value-of select="@name" /></td>
						<td><xsl:value-of select="@units" /></td>
						<td><xsl:value-of select="@nativeUnits" /></td>
						<td><xsl:value-of select="@representation" /></td>
						<td><xsl:value-of select="@sampleRate" /></td>
						<td><xsl:value-of select="@nativeScale" /></td>
						<td><xsl:value-of select="@statistic" /></td>
					</tr>
				</xsl:for-each>
			</tbody>
		</table>
	</xsl:template>
	
	<xsl:template match="m:Components">
		<xsl:param name="depth"/>
		<ul>
			<xsl:for-each select="./*">
				<li>
					<h3><xsl:value-of select="name()"/><xsl:text>: </xsl:text><xsl:value-of select="@name" /><xsl:text> (</xsl:text><xsl:value-of select="@nativeName"/><xsl:text>)</xsl:text></h3>
					<xsl:apply-templates select="m:Description"/>
					<xsl:apply-templates select="m:DataItems"/>
					<xsl:apply-templates select="m:Components">
						<xsl:with-param name="depth" select="$depth+1" />
					</xsl:apply-templates>
				</li>
			</xsl:for-each>
		</ul>
	</xsl:template>
	
</xsl:stylesheet>
