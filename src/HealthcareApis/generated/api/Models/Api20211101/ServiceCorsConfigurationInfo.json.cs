// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>The settings for the CORS configuration of the service instance.</summary>
    public partial class ServiceCorsConfigurationInfo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceCorsConfigurationInfo.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceCorsConfigurationInfo.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceCorsConfigurationInfo FromJson(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject json ? new ServiceCorsConfigurationInfo(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject into a new instance of <see cref="ServiceCorsConfigurationInfo" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ServiceCorsConfigurationInfo(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_origin = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonArray>("origins"), out var __jsonOrigins) ? If( __jsonOrigins as Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : Origin;}
            {_header = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonArray>("headers"), out var __jsonHeaders) ? If( __jsonHeaders as Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : Header;}
            {_method = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonArray>("methods"), out var __jsonMethods) ? If( __jsonMethods as Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : Method;}
            {_maxAge = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNumber>("maxAge"), out var __jsonMaxAge) ? (int?)__jsonMaxAge : MaxAge;}
            {_allowCredentials = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonBoolean>("allowCredentials"), out var __jsonAllowCredentials) ? (bool?)__jsonAllowCredentials : AllowCredentials;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ServiceCorsConfigurationInfo" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ServiceCorsConfigurationInfo" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (null != this._origin)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.XNodeArray();
                foreach( var __x in this._origin )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("origins",__w);
            }
            if (null != this._header)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.XNodeArray();
                foreach( var __s in this._header )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("headers",__r);
            }
            if (null != this._method)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.XNodeArray();
                foreach( var __n in this._method )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("methods",__m);
            }
            AddIf( null != this._maxAge ? (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNumber((int)this._maxAge) : null, "maxAge" ,container.Add );
            AddIf( null != this._allowCredentials ? (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonBoolean((bool)this._allowCredentials) : null, "allowCredentials" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}