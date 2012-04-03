
function Generate-NuSpecFile
{
param(
	[string]$version,
	[string]$file = $(throw "file is a required parameter.")
)
  $nuspec = "<?xml version=""1.0""?>
<package>
  <metadata>
    <id>dotLastFm</id>
    <version>$version</version>
    <authors>Tomáš Pastorek</authors>
    <licenseUrl>https://github.com/topas/dotLastFm/blob/master/LICENSE</licenseUrl>
    <projectUrl>http://topas.github.com/dotLastFm/</projectUrl>
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <description>Simple .NET wrapper for Last.fm API</description>
    <summary>Simple .NET wrapper for Last.fm API</summary>
    <language>en-US</language>
	<dependencies>
      <dependency id=""RestSharp"" version="""" />
    </dependencies>
  </metadata>
</package>
"

	$dir = [System.IO.Path]::GetDirectoryName($file)
	if ([System.IO.Directory]::Exists($dir) -eq $false)
	{
		Write-Host "Creating directory $dir"
		[System.IO.Directory]::CreateDirectory($dir)
	}
	Write-Host "Generating nuspec file: $file"
	Write-Output $nuspec > $file
}