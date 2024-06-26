// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The parameters for a quick task run request.</summary>
    public partial class EncodedTaskRunRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IEncodedTaskRunRequest,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IEncodedTaskRunRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequest __runRequest = new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.RunRequest();

        /// <summary>Backing field for <see cref="AgentConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentProperties _agentConfiguration;

        /// <summary>The machine configuration of the run agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentProperties AgentConfiguration { get => (this._agentConfiguration = this._agentConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.AgentProperties()); set => this._agentConfiguration = value; }

        /// <summary>The CPU configuration in terms of number of cores required for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public int? AgentConfigurationCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPropertiesInternal)AgentConfiguration).Cpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPropertiesInternal)AgentConfiguration).Cpu = value ?? default(int); }

        /// <summary>The dedicated agent pool for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public string AgentPoolName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)__runRequest).AgentPoolName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)__runRequest).AgentPoolName = value ?? null; }

        /// <summary>Backing field for <see cref="Credentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentials _credentials;

        /// <summary>
        /// The properties that describes a set of credentials that will be used when this run is invoked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentials Credentials { get => (this._credentials = this._credentials ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.Credentials()); set => this._credentials = value; }

        /// <summary>
        /// Describes the credential parameters for accessing other custom registries. The key
        /// for the dictionary item will be the registry login server (myregistry.azurecr.io) and
        /// the value of the item will be the registry credentials for accessing the registry.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsCustomRegistries CredentialsCustomRegistry { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).CustomRegistry; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).CustomRegistry = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="EncodedTaskContent" /> property.</summary>
        private string _encodedTaskContent;

        /// <summary>Base64 encoded value of the template/definition file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string EncodedTaskContent { get => this._encodedTaskContent; set => this._encodedTaskContent = value; }

        /// <summary>Backing field for <see cref="EncodedValuesContent" /> property.</summary>
        private string _encodedValuesContent;

        /// <summary>Base64 encoded value of the parameters/values file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string EncodedValuesContent { get => this._encodedValuesContent; set => this._encodedValuesContent = value; }

        /// <summary>The value that indicates whether archiving is enabled for the run or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public bool? IsArchiveEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)__runRequest).IsArchiveEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)__runRequest).IsArchiveEnabled = value ?? default(bool); }

        /// <summary>
        /// The template that describes the repository and tag information for run log artifact.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public string LogTemplate { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)__runRequest).LogTemplate; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)__runRequest).LogTemplate = value ?? null; }

        /// <summary>Internal Acessors for AgentConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IEncodedTaskRunRequestInternal.AgentConfiguration { get => (this._agentConfiguration = this._agentConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.AgentProperties()); set { {_agentConfiguration = value;} } }

        /// <summary>Internal Acessors for Credentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentials Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IEncodedTaskRunRequestInternal.Credentials { get => (this._credentials = this._credentials ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.Credentials()); set { {_credentials = value;} } }

        /// <summary>Internal Acessors for CredentialsSourceRegistry</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceRegistryCredentials Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IEncodedTaskRunRequestInternal.CredentialsSourceRegistry { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).SourceRegistry; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).SourceRegistry = value; }

        /// <summary>Internal Acessors for Platform</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IEncodedTaskRunRequestInternal.Platform { get => (this._platform = this._platform ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.PlatformProperties()); set { {_platform = value;} } }

        /// <summary>Backing field for <see cref="Platform" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformProperties _platform;

        /// <summary>The platform properties against which the run has to happen.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformProperties Platform { get => (this._platform = this._platform ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.PlatformProperties()); set => this._platform = value; }

        /// <summary>The OS architecture.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Architecture? PlatformArchitecture { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformPropertiesInternal)Platform).Architecture; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformPropertiesInternal)Platform).Architecture = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Architecture)""); }

        /// <summary>The operating system type required for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.OS PlatformOS { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformPropertiesInternal)Platform).OS; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformPropertiesInternal)Platform).OS = value ; }

        /// <summary>Variant of the CPU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Variant? PlatformVariant { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformPropertiesInternal)Platform).Variant; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformPropertiesInternal)Platform).Variant = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Variant)""); }

        /// <summary>Backing field for <see cref="SourceLocation" /> property.</summary>
        private string _sourceLocation;

        /// <summary>
        /// The URL(absolute or relative) of the source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from calling listBuildSourceUploadUrl API.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string SourceLocation { get => this._sourceLocation; set => this._sourceLocation = value; }

        /// <summary>
        /// The authentication mode which determines the source registry login scope. The credentials for the source registry
        /// will be generated using the given scope. These credentials will be used to login to
        /// the source registry during the run.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceRegistryLoginMode? SourceRegistryLoginMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).SourceRegistryLoginMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).SourceRegistryLoginMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceRegistryLoginMode)""); }

        /// <summary>Backing field for <see cref="Timeout" /> property.</summary>
        private int? _timeout;

        /// <summary>Run timeout in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public int? Timeout { get => this._timeout; set => this._timeout = value; }

        /// <summary>The type of the run request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)__runRequest).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)__runRequest).Type = value ; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISetValue[] _value;

        /// <summary>The collection of overridable values that can be passed when running a task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISetValue[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="EncodedTaskRunRequest" /> instance.</summary>
        public EncodedTaskRunRequest()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__runRequest), __runRequest);
            await eventListener.AssertObjectIsValid(nameof(__runRequest), __runRequest);
        }
    }
    /// The parameters for a quick task run request.
    public partial interface IEncodedTaskRunRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequest
    {
        /// <summary>The CPU configuration in terms of number of cores required for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CPU configuration in terms of number of cores required for the run.",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(int) })]
        int? AgentConfigurationCpu { get; set; }
        /// <summary>
        /// Describes the credential parameters for accessing other custom registries. The key
        /// for the dictionary item will be the registry login server (myregistry.azurecr.io) and
        /// the value of the item will be the registry credentials for accessing the registry.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Describes the credential parameters for accessing other custom registries. The key
        for the dictionary item will be the registry login server (myregistry.azurecr.io) and
        the value of the item will be the registry credentials for accessing the registry.",
        SerializedName = @"customRegistries",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsCustomRegistries) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsCustomRegistries CredentialsCustomRegistry { get; set; }
        /// <summary>Base64 encoded value of the template/definition file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Base64 encoded value of the template/definition file content.",
        SerializedName = @"encodedTaskContent",
        PossibleTypes = new [] { typeof(string) })]
        string EncodedTaskContent { get; set; }
        /// <summary>Base64 encoded value of the parameters/values file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Base64 encoded value of the parameters/values file content.",
        SerializedName = @"encodedValuesContent",
        PossibleTypes = new [] { typeof(string) })]
        string EncodedValuesContent { get; set; }
        /// <summary>The OS architecture.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The OS architecture.",
        SerializedName = @"architecture",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Architecture) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Architecture? PlatformArchitecture { get; set; }
        /// <summary>The operating system type required for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The operating system type required for the run.",
        SerializedName = @"os",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.OS) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.OS PlatformOS { get; set; }
        /// <summary>Variant of the CPU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Variant of the CPU.",
        SerializedName = @"variant",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Variant) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Variant? PlatformVariant { get; set; }
        /// <summary>
        /// The URL(absolute or relative) of the source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from calling listBuildSourceUploadUrl API.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL(absolute or relative) of the source context. It can be an URL to a tar or git repository.
        If it is relative URL, the relative path should be obtained from calling listBuildSourceUploadUrl API.",
        SerializedName = @"sourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string SourceLocation { get; set; }
        /// <summary>
        /// The authentication mode which determines the source registry login scope. The credentials for the source registry
        /// will be generated using the given scope. These credentials will be used to login to
        /// the source registry during the run.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The authentication mode which determines the source registry login scope. The credentials for the source registry
        will be generated using the given scope. These credentials will be used to login to
        the source registry during the run.",
        SerializedName = @"loginMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceRegistryLoginMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceRegistryLoginMode? SourceRegistryLoginMode { get; set; }
        /// <summary>Run timeout in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Run timeout in seconds.",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(int) })]
        int? Timeout { get; set; }
        /// <summary>The collection of overridable values that can be passed when running a task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of overridable values that can be passed when running a task.",
        SerializedName = @"values",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISetValue) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISetValue[] Value { get; set; }

    }
    /// The parameters for a quick task run request.
    internal partial interface IEncodedTaskRunRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal
    {
        /// <summary>The machine configuration of the run agent.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentProperties AgentConfiguration { get; set; }
        /// <summary>The CPU configuration in terms of number of cores required for the run.</summary>
        int? AgentConfigurationCpu { get; set; }
        /// <summary>
        /// The properties that describes a set of credentials that will be used when this run is invoked.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentials Credentials { get; set; }
        /// <summary>
        /// Describes the credential parameters for accessing other custom registries. The key
        /// for the dictionary item will be the registry login server (myregistry.azurecr.io) and
        /// the value of the item will be the registry credentials for accessing the registry.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsCustomRegistries CredentialsCustomRegistry { get; set; }
        /// <summary>Describes the credential parameters for accessing the source registry.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceRegistryCredentials CredentialsSourceRegistry { get; set; }
        /// <summary>Base64 encoded value of the template/definition file content.</summary>
        string EncodedTaskContent { get; set; }
        /// <summary>Base64 encoded value of the parameters/values file content.</summary>
        string EncodedValuesContent { get; set; }
        /// <summary>The platform properties against which the run has to happen.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformProperties Platform { get; set; }
        /// <summary>The OS architecture.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Architecture? PlatformArchitecture { get; set; }
        /// <summary>The operating system type required for the run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.OS PlatformOS { get; set; }
        /// <summary>Variant of the CPU.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Variant? PlatformVariant { get; set; }
        /// <summary>
        /// The URL(absolute or relative) of the source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from calling listBuildSourceUploadUrl API.
        /// </summary>
        string SourceLocation { get; set; }
        /// <summary>
        /// The authentication mode which determines the source registry login scope. The credentials for the source registry
        /// will be generated using the given scope. These credentials will be used to login to
        /// the source registry during the run.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceRegistryLoginMode? SourceRegistryLoginMode { get; set; }
        /// <summary>Run timeout in seconds.</summary>
        int? Timeout { get; set; }
        /// <summary>The collection of overridable values that can be passed when running a task.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISetValue[] Value { get; set; }

    }
}