// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    /// <summary>
    /// Customer retrieves list of Available Contacts for a spacecraft resource. Later, one of the available contact can be selected
    /// to create a contact.
    /// </summary>
    public partial class AvailableContacts :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContacts,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal
    {

        /// <summary>Azimuth of the antenna at the end of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 2)]
        public float? EndAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).EndAzimuthDegree; }

        /// <summary>Spacecraft elevation above the horizon at contact end.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 4)]
        public float? EndElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).EndElevationDegree; }

        /// <summary>Backing field for <see cref="GroundStationName" /> property.</summary>
        private string _groundStationName;

        /// <summary>Name of Azure Ground Station.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 0)]
        public string GroundStationName { get => this._groundStationName; }

        /// <summary>Maximum elevation of the antenna during the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 5)]
        public float? MaximumElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).MaximumElevationDegree; }

        /// <summary>Internal Acessors for EndAzimuthDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.EndAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).EndAzimuthDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).EndAzimuthDegree = value; }

        /// <summary>Internal Acessors for EndElevationDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.EndElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).EndElevationDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).EndElevationDegree = value; }

        /// <summary>Internal Acessors for GroundStationName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.GroundStationName { get => this._groundStationName; set { {_groundStationName = value;} } }

        /// <summary>Internal Acessors for MaximumElevationDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.MaximumElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).MaximumElevationDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).MaximumElevationDegree = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstanceProperties Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ContactInstanceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RxEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.RxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).RxEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).RxEndTime = value; }

        /// <summary>Internal Acessors for RxStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.RxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).RxStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).RxStartTime = value; }

        /// <summary>Internal Acessors for Spacecraft</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IResourceReference Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.Spacecraft { get => (this._spacecraft = this._spacecraft ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ResourceReference()); set { {_spacecraft = value;} } }

        /// <summary>Internal Acessors for StartAzimuthDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.StartAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).StartAzimuthDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).StartAzimuthDegree = value; }

        /// <summary>Internal Acessors for StartElevationDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.StartElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).StartElevationDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).StartElevationDegree = value; }

        /// <summary>Internal Acessors for TxEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.TxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).TxEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).TxEndTime = value; }

        /// <summary>Internal Acessors for TxStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IAvailableContactsInternal.TxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).TxStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).TxStartTime = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstanceProperties _property;

        /// <summary>Properties of Contact resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstanceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ContactInstanceProperties()); set => this._property = value; }

        /// <summary>Time to lost receiving a signal (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 7)]
        public global::System.DateTime? RxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).RxEndTime; }

        /// <summary>Earliest time to receive a signal (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 6)]
        public global::System.DateTime? RxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).RxStartTime; }

        /// <summary>Backing field for <see cref="Spacecraft" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IResourceReference _spacecraft;

        /// <summary>The reference to the spacecraft resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IResourceReference Spacecraft { get => (this._spacecraft = this._spacecraft ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ResourceReference()); set => this._spacecraft = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string SpacecraftId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IResourceReferenceInternal)Spacecraft).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IResourceReferenceInternal)Spacecraft).Id = value ?? null; }

        /// <summary>Azimuth of the antenna at the start of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 1)]
        public float? StartAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).StartAzimuthDegree; }

        /// <summary>Spacecraft elevation above the horizon at contact start.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 3)]
        public float? StartElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).StartElevationDegree; }

        /// <summary>Time at which antenna transmit will be disabled (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? TxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).TxEndTime; }

        /// <summary>Time at which antenna transmit will be enabled (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? TxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstancePropertiesInternal)Property).TxStartTime; }

        /// <summary>Creates an new <see cref="AvailableContacts" /> instance.</summary>
        public AvailableContacts()
        {

        }
    }
    /// Customer retrieves list of Available Contacts for a spacecraft resource. Later, one of the available contact can be selected
    /// to create a contact.
    public partial interface IAvailableContacts :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IJsonSerializable
    {
        /// <summary>Azimuth of the antenna at the end of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azimuth of the antenna at the end of the contact in decimal degrees.",
        SerializedName = @"endAzimuthDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? EndAzimuthDegree { get;  }
        /// <summary>Spacecraft elevation above the horizon at contact end.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Spacecraft elevation above the horizon at contact end.",
        SerializedName = @"endElevationDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? EndElevationDegree { get;  }
        /// <summary>Name of Azure Ground Station.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of Azure Ground Station.",
        SerializedName = @"groundStationName",
        PossibleTypes = new [] { typeof(string) })]
        string GroundStationName { get;  }
        /// <summary>Maximum elevation of the antenna during the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Maximum elevation of the antenna during the contact in decimal degrees.",
        SerializedName = @"maximumElevationDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? MaximumElevationDegree { get;  }
        /// <summary>Time to lost receiving a signal (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time to lost receiving a signal (ISO 8601 UTC standard).",
        SerializedName = @"rxEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RxEndTime { get;  }
        /// <summary>Earliest time to receive a signal (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Earliest time to receive a signal (ISO 8601 UTC standard).",
        SerializedName = @"rxStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RxStartTime { get;  }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SpacecraftId { get; set; }
        /// <summary>Azimuth of the antenna at the start of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azimuth of the antenna at the start of the contact in decimal degrees.",
        SerializedName = @"startAzimuthDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? StartAzimuthDegree { get;  }
        /// <summary>Spacecraft elevation above the horizon at contact start.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Spacecraft elevation above the horizon at contact start.",
        SerializedName = @"startElevationDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? StartElevationDegree { get;  }
        /// <summary>Time at which antenna transmit will be disabled (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time at which antenna transmit will be disabled (ISO 8601 UTC standard).",
        SerializedName = @"txEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TxEndTime { get;  }
        /// <summary>Time at which antenna transmit will be enabled (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time at which antenna transmit will be enabled (ISO 8601 UTC standard).",
        SerializedName = @"txStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TxStartTime { get;  }

    }
    /// Customer retrieves list of Available Contacts for a spacecraft resource. Later, one of the available contact can be selected
    /// to create a contact.
    internal partial interface IAvailableContactsInternal

    {
        /// <summary>Azimuth of the antenna at the end of the contact in decimal degrees.</summary>
        float? EndAzimuthDegree { get; set; }
        /// <summary>Spacecraft elevation above the horizon at contact end.</summary>
        float? EndElevationDegree { get; set; }
        /// <summary>Name of Azure Ground Station.</summary>
        string GroundStationName { get; set; }
        /// <summary>Maximum elevation of the antenna during the contact in decimal degrees.</summary>
        float? MaximumElevationDegree { get; set; }
        /// <summary>Properties of Contact resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IContactInstanceProperties Property { get; set; }
        /// <summary>Time to lost receiving a signal (ISO 8601 UTC standard).</summary>
        global::System.DateTime? RxEndTime { get; set; }
        /// <summary>Earliest time to receive a signal (ISO 8601 UTC standard).</summary>
        global::System.DateTime? RxStartTime { get; set; }
        /// <summary>The reference to the spacecraft resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IResourceReference Spacecraft { get; set; }
        /// <summary>Resource ID.</summary>
        string SpacecraftId { get; set; }
        /// <summary>Azimuth of the antenna at the start of the contact in decimal degrees.</summary>
        float? StartAzimuthDegree { get; set; }
        /// <summary>Spacecraft elevation above the horizon at contact start.</summary>
        float? StartElevationDegree { get; set; }
        /// <summary>Time at which antenna transmit will be disabled (ISO 8601 UTC standard).</summary>
        global::System.DateTime? TxEndTime { get; set; }
        /// <summary>Time at which antenna transmit will be enabled (ISO 8601 UTC standard).</summary>
        global::System.DateTime? TxStartTime { get; set; }

    }
}