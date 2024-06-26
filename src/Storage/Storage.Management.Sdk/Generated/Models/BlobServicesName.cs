// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{

    /// <summary>
    /// Defines values for BlobServicesName.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BlobServicesName
    {
        [System.Runtime.Serialization.EnumMember(Value = "default")]
        Default
    }
    internal static class BlobServicesNameEnumExtension
    {
        internal static string ToSerializedValue(this BlobServicesName? value)
        {
            return value == null ? null : ((BlobServicesName)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this BlobServicesName value)
        {
            switch( value )
            {
                case BlobServicesName.Default:
                    return "default";
            }
            return null;
        }
        internal static BlobServicesName? ParseBlobServicesName(this string value)
        {
            switch( value )
            {
                case "default":
                    return BlobServicesName.Default;
            }
            return null;
        }
    }
}