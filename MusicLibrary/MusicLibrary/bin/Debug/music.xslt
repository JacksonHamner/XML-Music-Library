<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="html" version="1.0" />
<xsl:template match="/">
  <html>
    <head>
      <title>Music Library</title>    
    </head>
    <body style="background-color: #F5D0A9;">
      <p style="text-align:center;font-size:50px;font-family:serif;"><u>Music Library</u></p>
      <p style="text-align:center;">
        <strong>A list of Artists, their albums and each song in that album for all the music in your Music Library</strong></p>
        <xsl:for-each select="musicLibrary/artist">
            <u style="font-size:30px;"><xsl:text>&#xA0;&#xA0;&#xA0;&#xA0;</xsl:text><xsl:value-of select="@name"/><xsl:text>&#xA0;&#xA0;&#xA0;&#xA0;</xsl:text></u>
          <ul>            
          <xsl:for-each select="album">
            <li>
              <strong style="font-size:20px;">
                <u><xsl:value-of select="@name"/></u></strong>
              <br/><strong>Genre: </strong><xsl:value-of select="genre"/> <br/> <strong>Release Date: </strong><xsl:value-of select="releaseDate"/>
              <br/>
            </li>
              <table border="1"  style="background-color:white; border-style:dashed;">
                <th>Track #</th>
                <th>Title</th>
                <th>Duration</th>
                <th>Rating</th>
              <xsl:for-each select ="songs/song">
                <tr>
                  <td style="text-align:center;"><xsl:value-of select="@number"/></td>
                  <td><xsl:value-of select="title"/></td>
                  <td style="text-align:center;"><xsl:value-of select="duration"/></td>
                  <td style="text-align:center;"><xsl:value-of select="rating/@stars"/><xsl:text>&#xA0;Stars</xsl:text>
                  </td>
                </tr>
            </xsl:for-each>
            </table> 

          <br />
          </xsl:for-each>
          </ul>
 
        <br />
        </xsl:for-each>
    </body>
  </html>
</xsl:template>
  
</xsl:stylesheet>