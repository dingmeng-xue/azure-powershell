### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
csharp: true
clear-output-folder: true
```

### Tag: PrivateDns

``` yaml $(tag) == 'PrivateDns'
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/privatedns/resource-manager/Microsoft.Network/stable/2018-09-01/privatedns.json

output-folder: PrivateDns

namespace: Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.PrivateDns

directive:
  - remove-operation:
    - PrivateZones_Update
    - PrivateZones_Delete
    - PrivateZones_Get
    - PrivateZones_List
    - PrivateZones_ListByResourceGroup
    - VirtualNetworkLinks_Update
    - VirtualNetworkLinks_Delete
    - VirtualNetworkLinks_Get
    - RecordSets_Update
    - RecordSets_Delete
    - RecordSets_Get
    - RecordSets_ListByType
    - RecordSets_List
```

### Tag: Network

``` yaml $(tag) == 'Network'
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2020-07-01/virtualNetwork.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2020-07-01/privateEndpoint.json

output-folder: Network

namespace: Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.Network

directive:
  - remove-operation:
    - PrivateEndpoints_Delete
    - PrivateEndpoints_Get
    - PrivateEndpoints_List
    - PrivateEndpoints_ListBySubscription
    - AvailablePrivateEndpointTypes_List
    - AvailablePrivateEndpointTypes_ListByResourceGroup
    - PrivateDnsZoneGroups_Delete
    - PrivateDnsZoneGroups_Get
    - PrivateDnsZoneGroups_CreateOrUpdate
    - PrivateDnsZoneGroups_List
    - VirtualNetworks_Delete
    - VirtualNetworks_Get
    - VirtualNetworks_CreateOrUpdate
    - VirtualNetworks_UpdateTags
    - VirtualNetworks_List
    - Subnets_Delete
    - Subnets_PrepareNetworkPolicies
    - Subnets_UnprepareNetworkPolicies
    - ResourceNavigationLinks_List
    - ServiceAssociationLinks_List
    - Subnets_List
    - VirtualNetworkPeerings_Delete
    - VirtualNetworkPeerings_Get
    - VirtualNetworkPeerings_CreateOrUpdate
    - VirtualNetworkPeerings_List
    - VirtualNetworks_CheckIPAddressAvailability
    - VirtualNetworks_ListUsage
```