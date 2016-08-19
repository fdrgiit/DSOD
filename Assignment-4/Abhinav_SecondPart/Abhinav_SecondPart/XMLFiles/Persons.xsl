<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<html>
			<body>
				<h1 style="text-align: left; font-color: #87ceeb; font-family: gabriola;">Personal Directory</h1>
					<xsl:for-each select="Persons/Person">
						<xsl:sort select="Category" />
						<div style="border: 1px #000000 solid; font: 14px consolas;">
							<ul>
								<li style="font-weight: bold;">
									<xsl:for-each select="Name">
									<label>NAME: </label>
										<label><xsl:value-of select="First"/>&#160;</label>
										<label><xsl:value-of select="Last"/>&#160;</label>
									</xsl:for-each>
								</li>
								<li>
									<xsl:for-each select="Credential">
									<label style="font-weight: bold;">USER CREDENTIALS: </label>
									<li>
									<li>
										<label>UserId: <xsl:value-of select="Id"/>&#160;</label>	
										<li><label>Password: <xsl:value-of select="Password"/>&#160;</label></li>
										<label>Encryption: <xsl:value-of select="Password/@Encryption"/>&#160;</label>
									</li>	
									</li>	
									</xsl:for-each>
								</li>
								<li>
									<xsl:for-each select="Phone">
									<label style="font-weight: bold;">CALL DETAILS: </label>
									<li>
										<label>Work No.: <xsl:value-of select="Work"/>&#160;</label>
										<li><label>Mobile No. : <xsl:value-of select="Cell"/>&#160;</label></li>
										<label>Service Provider: <xsl:value-of select="Cell/@Provider"/>&#160;</label>
									</li>	
									</xsl:for-each>
								</li>								
								<li>
									<label style="font-weight: bold;">CATEGORY: </label>
									<label><xsl:value-of select="Category"/></label>
								</li>
							</ul>
						</div>
					</xsl:for-each>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>