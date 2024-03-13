$ProjectPath = "$PSScriptRoot\src\Nav-Code-Analyzer.csproj"
$OutputPath = "$PSScriptRoot\src\bin"
$InstallFolder = "$env:LOCALAPPDATA\Nav-Code-Analyzer"

dotnet build `
    $ProjectPath `
    --configuration Release `
    --output $OutputPath

Write-Host "Copying files to $InstallFolder"
Copy-Item -Path "$PSScriptRoot\src\bin" -Destination "$InstallFolder" -Recurse -Force