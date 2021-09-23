<!-- region Generated -->
# Az.Quota
This directory contains the PowerShell module for the Quota service.

---
## Status
[![Az.Quota](https://img.shields.io/powershellgallery/v/Az.Quota.svg?style=flat-square&label=Az.Quota "Az.Quota")](https://www.powershellgallery.com/packages/Az.Quota/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 2.2.3 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.Quota`, see [how-to.md](how-to.md).
<!-- endregion -->

---
## Generation Requirements
Use of the beta version of `autorest.powershell` generator requires the following:
- [NodeJS LTS](https://nodejs.org) (10.15.x LTS preferred)
  - **Note**: It *will not work* with Node < 10.x. Using 11.x builds may cause issues as they may introduce instability or breaking changes.
> If you want an easy way to install and update Node, [NVS - Node Version Switcher](../nodejs/installing-via-nvs.md) or [NVM - Node Version Manager](../nodejs/installing-via-nvm.md) is recommended.
- [AutoRest](https://aka.ms/autorest) v3 beta <br>`npm install -g autorest@autorest`<br>&nbsp;
- PowerShell 6.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g pwsh`<br>&nbsp;
- .NET Core SDK 2.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g dotnet-sdk-2.2`<br>&nbsp;

## Run Generation
In this directory, run AutoRest:
> `autorest-beta`

---
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
branch: 21ffb64fdcbc0da039117af64f13c028c20d1286
require:
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
  - $(repo)/specification/quota/resource-manager/Microsoft.Quota/preview/2021-03-15-preview/quota.json

title: Quota
module-version: 0.1.0
resourcegroup-append: true

directive:
  # Remove the unexpanded parameter set
  - where:
      variant: ^Create$|^CreateViaIdentityExpanded$|^Update$|^UpdateViaIdentity$
    remove: true

  - where:
      verb: Set
    remove: true

  - where:
      subject: QuotaRequestStatus
    set:
      subject: Request
```
