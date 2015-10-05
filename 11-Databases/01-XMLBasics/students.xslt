<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
  <html>
  <style>
    th {
      background-color: #eee;
      text-align: center;
    }

    table, th, td {
      border: 2px solid #00a;
    }

    ul {
      margin: 0;
      padding: 0;
      list-style: none;
    }

    td {
      padding: 5px
    }

    .highlight {
      font-weight: bold;
      color: red;
    }
  </style>
  <body>
  <h2>Students</h2>
    <table>
      <tr>
        <th>Name</th>
        <th>Sex</th>
        <th>Birthday</th>
        <th>Phone</th>
        <th>Email</th>
        <th>Course</th>
        <th>Specialty</th>
        <th>Faculty number</th>
        <th>Passed exams</th>
      </tr>
      <xsl:for-each select="students/student">
      <tr>
        <td><xsl:value-of select="name"/></td>
        <td><xsl:value-of select="sex"/></td>
        <td><xsl:value-of select="birthDate"/></td>
        <td><xsl:value-of select="phone"/></td>
        <td><xsl:value-of select="email"/></td>
        <td><xsl:value-of select="course"/></td>
        <td><xsl:value-of select="specialty"/></td>
        <td><xsl:value-of select="facultyNumber"/></td>
        <td>
          <ul>
            <xsl:for-each select="passedExams/exam">
              <li>
                <span class="highlight"> Name: </span><xsl:value-of select="name"/>
                <span class="highlight"> Tutor: </span><xsl:value-of select="tutor"/>
                <span class="highlight"> Score: </span><xsl:value-of select="score"/>
              </li>
            </xsl:for-each>
          </ul>
        </td>
      </tr>
      </xsl:for-each>
    </table>
  </body>
  </html>
</xsl:template>
</xsl:stylesheet>