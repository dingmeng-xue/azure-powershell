// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    public partial class DatabricksIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject into a new instance of <see cref="DatabricksIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DatabricksIdentity(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_workspaceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString>("workspaceName"), out var __jsonWorkspaceName) ? (string)__jsonWorkspaceName : (string)WorkspaceName;}
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_groupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString>("groupId"), out var __jsonGroupId) ? (string)__jsonGroupId : (string)GroupId;}
            {_privateEndpointConnectionName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString>("privateEndpointConnectionName"), out var __jsonPrivateEndpointConnectionName) ? (string)__jsonPrivateEndpointConnectionName : (string)PrivateEndpointConnectionName;}
            {_peeringName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString>("peeringName"), out var __jsonPeeringName) ? (string)__jsonPeeringName : (string)PeeringName;}
            {_connectorName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString>("connectorName"), out var __jsonConnectorName) ? (string)__jsonConnectorName : (string)ConnectorName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IDatabricksIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IDatabricksIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IDatabricksIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject json ? new DatabricksIdentity(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DatabricksIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DatabricksIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._workspaceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString(this._workspaceName.ToString()) : null, "workspaceName" ,container.Add );
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._groupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString(this._groupId.ToString()) : null, "groupId" ,container.Add );
            AddIf( null != (((object)this._privateEndpointConnectionName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString(this._privateEndpointConnectionName.ToString()) : null, "privateEndpointConnectionName" ,container.Add );
            AddIf( null != (((object)this._peeringName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString(this._peeringName.ToString()) : null, "peeringName" ,container.Add );
            AddIf( null != (((object)this._connectorName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString(this._connectorName.ToString()) : null, "connectorName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}