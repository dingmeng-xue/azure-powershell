// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>
    /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CustomHttpsProvisioningSubstateTypeConverter))]
    public partial struct CustomHttpsProvisioningSubstate :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SubmittingDomainControlValidationRequest".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SubmittingDomainControlValidationRequest'", "SubmittingDomainControlValidationRequest", global::System.Management.Automation.CompletionResultType.ParameterValue, "SubmittingDomainControlValidationRequest");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PendingDomainControlValidationREquestApproval".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PendingDomainControlValidationREquestApproval'", "PendingDomainControlValidationREquestApproval", global::System.Management.Automation.CompletionResultType.ParameterValue, "PendingDomainControlValidationREquestApproval");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DomainControlValidationRequestApproved".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DomainControlValidationRequestApproved'", "DomainControlValidationRequestApproved", global::System.Management.Automation.CompletionResultType.ParameterValue, "DomainControlValidationRequestApproved");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DomainControlValidationRequestRejected".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DomainControlValidationRequestRejected'", "DomainControlValidationRequestRejected", global::System.Management.Automation.CompletionResultType.ParameterValue, "DomainControlValidationRequestRejected");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DomainControlValidationRequestTimedOut".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DomainControlValidationRequestTimedOut'", "DomainControlValidationRequestTimedOut", global::System.Management.Automation.CompletionResultType.ParameterValue, "DomainControlValidationRequestTimedOut");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "IssuingCertificate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'IssuingCertificate'", "IssuingCertificate", global::System.Management.Automation.CompletionResultType.ParameterValue, "IssuingCertificate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DeployingCertificate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DeployingCertificate'", "DeployingCertificate", global::System.Management.Automation.CompletionResultType.ParameterValue, "DeployingCertificate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CertificateDeployed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'CertificateDeployed'", "CertificateDeployed", global::System.Management.Automation.CompletionResultType.ParameterValue, "CertificateDeployed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DeletingCertificate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DeletingCertificate'", "DeletingCertificate", global::System.Management.Automation.CompletionResultType.ParameterValue, "DeletingCertificate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CertificateDeleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'CertificateDeleted'", "CertificateDeleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "CertificateDeleted");
            }
        }
    }
}