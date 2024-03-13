[CmdletBinding()]
param (
    [Parameter(Mandatory=$true)]
    [string]
    $Path
)

$InstallFolder = "$env:LOCALAPPDATA\Nav-Code-Analyzer"

Import-Module "$InstallFolder\bin\Nav-Code-Analyzer.dll"

$analyzer = New-Object Nav_Code_Analyzer.Analyzer
$analyzer.Analyze($Path)