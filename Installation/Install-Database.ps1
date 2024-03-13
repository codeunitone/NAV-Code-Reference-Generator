param(
    [switch]
    $Force
)

$ErrorActionPreference = "Stop"

$InstallFolder = "$env:LOCALAPPDATA\Nav-Code-Analyzer"
$dbName = "Nav-Code-Analyzer.db"
$dbPath = "$InstallFolder\$dbName"

# check if the code analyzer is already installed. Recreate if -Force is specified
if (Test-Path -Path $InstallFolder) {
    if ($Force) {
        Remove-Item -Recurse -Force $InstallFolder
    } else {
        Write-Host "Database already exists. Use -Force to overwrite."
        return
    }
}
New-Item -ItemType Directory -Path $InstallFolder | Out-Null

# setup the database
sqlite3 -batch "$dbPath" .databases
$tableCreationCommand = @"
CREATE TABLE Object (
    guid TEXT PRIMARY KEY,
    type TEXT NOT NULL,
    id INTEGER NOT NULL,
    name TEXT NOT NULL
);
"@
sqlite3 -batch $dbPath $tableCreationCommand