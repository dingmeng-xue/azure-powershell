// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support
{

    /// <summary>The authentication type.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AuthTypeTypeConverter))]
    public partial struct AuthType :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "systemAssignedIdentity".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'systemAssignedIdentity'", "systemAssignedIdentity", global::System.Management.Automation.CompletionResultType.ParameterValue, "systemAssignedIdentity");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "userAssignedIdentity".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'userAssignedIdentity'", "userAssignedIdentity", global::System.Management.Automation.CompletionResultType.ParameterValue, "userAssignedIdentity");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "servicePrincipalSecret".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'servicePrincipalSecret'", "servicePrincipalSecret", global::System.Management.Automation.CompletionResultType.ParameterValue, "servicePrincipalSecret");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "servicePrincipalCertificate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'servicePrincipalCertificate'", "servicePrincipalCertificate", global::System.Management.Automation.CompletionResultType.ParameterValue, "servicePrincipalCertificate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "secret".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'secret'", "secret", global::System.Management.Automation.CompletionResultType.ParameterValue, "secret");
            }
        }
    }
}