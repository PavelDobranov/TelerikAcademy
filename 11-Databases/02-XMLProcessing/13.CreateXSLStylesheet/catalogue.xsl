﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/catalogue">    
    <html>
      <head>
        <title>Albums Catalogue</title>
        <style>
          table {
            border-collapse: collapse;
          }

          table, th, td {
            border: 2px solid black;
          } 
          
          th, td {
            padding: 5px;
          }

          th {
            background-color: #eeeeee
          }
        </style>
      </head>
      <body>
        <h3>Albums Catalogue</h3>
        <table>
          <tr>
            <th>Name</th>
            <th>Artist</th>
            <th>Released</th>
            <th>Producer</th>
            <th>Price</th>
            <th>Songs</th>
          </tr>
          <xsl:for-each select="album">
            <tr>
              <td>
                <xsl:value-of select="name" />
              </td>
              <td>
                <xsl:value-of select="artist" />
              </td>
              <td>
                <xsl:value-of select="year" />
              </td>
              <td>
                <xsl:value-of select="producer" />
              </td>
              <td>
                $<xsl:value-of select="price" />
              </td>
              <td>
                <xsl:for-each select="songs/song">
                  <div>                    
                    <strong>
                      <xsl:value-of select="title"/>
                    </strong> -
                    <xsl:value-of select="duration"/> min
                  </div>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>