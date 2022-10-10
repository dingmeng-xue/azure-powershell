// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Represents an ip entity.</summary>
    public partial class IPEntity :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntity,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntity __entity = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.Entity();

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData AdditionalData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)Property).AdditionalData; }

        /// <summary>The IP address as string, e.g. 127.0.0.1 (either in Ipv4 or Ipv6)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string Address { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).Address; }

        /// <summary>
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is
        /// optional and might be system generated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)Property).FriendlyName; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).Id; }

        /// <summary>The kind of the entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInternal)__entity).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInternal)__entity).Kind = value ; }

        /// <summary>Autonomous System Number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public int? LocationAsn { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationAsn; }

        /// <summary>City name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string LocationCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationCity; }

        /// <summary>The country code according to ISO 3166 format</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string LocationCountryCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationCountryCode; }

        /// <summary>
        /// Country name according to ISO 3166 Alpha 2: the lowercase of the English Short Name
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string LocationCountryName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationCountryName; }

        /// <summary>
        /// The longitude of the identified location, expressed as a floating point number with range of -180 to 180, with positive
        /// numbers representing East and negative numbers representing West. Latitude and longitude are derived from the city or
        /// postal code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public double? LocationLatitude { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationLatitude; }

        /// <summary>
        /// The latitude of the identified location, expressed as a floating point number with range of - 90 to 90, with positive
        /// numbers representing North and negative numbers representing South. Latitude and longitude are derived from the city or
        /// postal code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public double? LocationLongitude { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationLongitude; }

        /// <summary>State name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string LocationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationState; }

        /// <summary>Internal Acessors for AdditionalData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.AdditionalData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)Property).AdditionalData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)Property).AdditionalData = value; }

        /// <summary>Internal Acessors for Address</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.Address { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).Address; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).Address = value; }

        /// <summary>Internal Acessors for FriendlyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)Property).FriendlyName = value; }

        /// <summary>Internal Acessors for Location</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IGeoLocation Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).Location = value; }

        /// <summary>Internal Acessors for LocationAsn</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.LocationAsn { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationAsn; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationAsn = value; }

        /// <summary>Internal Acessors for LocationCity</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.LocationCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationCity; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationCity = value; }

        /// <summary>Internal Acessors for LocationCountryCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.LocationCountryCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationCountryCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationCountryCode = value; }

        /// <summary>Internal Acessors for LocationCountryName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.LocationCountryName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationCountryName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationCountryName = value; }

        /// <summary>Internal Acessors for LocationLatitude</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.LocationLatitude { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationLatitude; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationLatitude = value; }

        /// <summary>Internal Acessors for LocationLongitude</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.LocationLongitude { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationLongitude; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationLongitude = value; }

        /// <summary>Internal Acessors for LocationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.LocationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).LocationState = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityProperties Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IPEntityProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ThreatIntelligence</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligence[] Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityInternal.ThreatIntelligence { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).ThreatIntelligence; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).ThreatIntelligence = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityProperties _property;

        /// <summary>Ip entity properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IPEntityProperties()); set => this._property = value; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType)""); }

        /// <summary>A list of TI contexts attached to the ip entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligence[] ThreatIntelligence { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityPropertiesInternal)Property).ThreatIntelligence; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entity).Type; }

        /// <summary>Creates an new <see cref="IPEntity" /> instance.</summary>
        public IPEntity()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__entity), __entity);
            await eventListener.AssertObjectIsValid(nameof(__entity), __entity);
        }
    }
    /// Represents an ip entity.
    public partial interface IIPEntity :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntity
    {
        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A bag of custom fields that should be part of the entity and will be presented to the user.",
        SerializedName = @"additionalData",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData AdditionalData { get;  }
        /// <summary>The IP address as string, e.g. 127.0.0.1 (either in Ipv4 or Ipv6)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The IP address as string, e.g. 127.0.0.1 (either in Ipv4 or Ipv6)",
        SerializedName = @"address",
        PossibleTypes = new [] { typeof(string) })]
        string Address { get;  }
        /// <summary>
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is
        /// optional and might be system generated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get;  }
        /// <summary>Autonomous System Number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Autonomous System Number",
        SerializedName = @"asn",
        PossibleTypes = new [] { typeof(int) })]
        int? LocationAsn { get;  }
        /// <summary>City name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"City name",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string LocationCity { get;  }
        /// <summary>The country code according to ISO 3166 format</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The country code according to ISO 3166 format",
        SerializedName = @"countryCode",
        PossibleTypes = new [] { typeof(string) })]
        string LocationCountryCode { get;  }
        /// <summary>
        /// Country name according to ISO 3166 Alpha 2: the lowercase of the English Short Name
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Country name according to ISO 3166 Alpha 2: the lowercase of the English Short Name",
        SerializedName = @"countryName",
        PossibleTypes = new [] { typeof(string) })]
        string LocationCountryName { get;  }
        /// <summary>
        /// The longitude of the identified location, expressed as a floating point number with range of -180 to 180, with positive
        /// numbers representing East and negative numbers representing West. Latitude and longitude are derived from the city or
        /// postal code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The longitude of the identified location, expressed as a floating point number with range of -180 to 180, with positive numbers representing East and negative numbers representing West. Latitude and longitude are derived from the city or postal code.",
        SerializedName = @"latitude",
        PossibleTypes = new [] { typeof(double) })]
        double? LocationLatitude { get;  }
        /// <summary>
        /// The latitude of the identified location, expressed as a floating point number with range of - 90 to 90, with positive
        /// numbers representing North and negative numbers representing South. Latitude and longitude are derived from the city or
        /// postal code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The latitude of the identified location, expressed as a floating point number with range of - 90 to 90, with positive numbers representing North and negative numbers representing South. Latitude and longitude are derived from the city or postal code.",
        SerializedName = @"longitude",
        PossibleTypes = new [] { typeof(double) })]
        double? LocationLongitude { get;  }
        /// <summary>State name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State name",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string LocationState { get;  }
        /// <summary>A list of TI contexts attached to the ip entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A list of TI contexts attached to the ip entity.",
        SerializedName = @"threatIntelligence",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligence) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligence[] ThreatIntelligence { get;  }

    }
    /// Represents an ip entity.
    internal partial interface IIPEntityInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityInternal
    {
        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData AdditionalData { get; set; }
        /// <summary>The IP address as string, e.g. 127.0.0.1 (either in Ipv4 or Ipv6)</summary>
        string Address { get; set; }
        /// <summary>
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is
        /// optional and might be system generated.
        /// </summary>
        string FriendlyName { get; set; }
        /// <summary>The geo-location context attached to the ip entity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IGeoLocation Location { get; set; }
        /// <summary>Autonomous System Number</summary>
        int? LocationAsn { get; set; }
        /// <summary>City name</summary>
        string LocationCity { get; set; }
        /// <summary>The country code according to ISO 3166 format</summary>
        string LocationCountryCode { get; set; }
        /// <summary>
        /// Country name according to ISO 3166 Alpha 2: the lowercase of the English Short Name
        /// </summary>
        string LocationCountryName { get; set; }
        /// <summary>
        /// The longitude of the identified location, expressed as a floating point number with range of -180 to 180, with positive
        /// numbers representing East and negative numbers representing West. Latitude and longitude are derived from the city or
        /// postal code.
        /// </summary>
        double? LocationLatitude { get; set; }
        /// <summary>
        /// The latitude of the identified location, expressed as a floating point number with range of - 90 to 90, with positive
        /// numbers representing North and negative numbers representing South. Latitude and longitude are derived from the city or
        /// postal code.
        /// </summary>
        double? LocationLongitude { get; set; }
        /// <summary>State name</summary>
        string LocationState { get; set; }
        /// <summary>Ip entity properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIPEntityProperties Property { get; set; }
        /// <summary>A list of TI contexts attached to the ip entity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligence[] ThreatIntelligence { get; set; }

    }
}