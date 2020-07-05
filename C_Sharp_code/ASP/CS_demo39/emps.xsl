<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:xsd="http://www.w3.org/2001/XMLSchema"
                xmlns:msxsl="urn:schemas-microsoft-com:xslt" 
                exclude-result-prefixes="msxsl"
>
  <xsl:strip-space elements="*"/>
  <xsl:output method="xml" omit-xml-declaration="yes" indent="yes" standalone="yes"/>

  <xsl:template match="/">
      <xsl:for-each select="NewDataSet">
        <xsl:element name="NewDataSet">
          <xsl:for-each select="Employees">
            <xsl:element name="Employees">
              <xsl:attribute name="EmployeeID">
                <xsl:value-of select="EmployeeID"/>
              </xsl:attribute>
              <xsl:attribute name="FirstName">
                <xsl:value-of select="FirstName"/>
              </xsl:attribute>
              <xsl:attribute name="LastName">
                <xsl:value-of select="LastName"/>
              </xsl:attribute>
              <xsl:attribute name="Title">
                <xsl:value-of select="Title"/>
              </xsl:attribute>
            </xsl:element>
          </xsl:for-each>
        </xsl:element>
      </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
