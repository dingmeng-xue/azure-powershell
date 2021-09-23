@{
  GUID = '45364a81-d61c-4b29-bf5a-24ac8b2ea819'
  RootModule = './Az.Quota.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Quota cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.Quota.private.dll'
  FormatsToProcess = './Az.Quota.format.ps1xml'
  FunctionsToExport = 'Get-AzQuota', 'Get-AzQuotaUsage', 'Get-AzRequest', 'New-AzQuota', 'Update-AzQuota', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Quota'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
