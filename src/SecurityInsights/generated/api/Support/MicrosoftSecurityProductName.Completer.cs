// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support
{

    /// <summary>The alerts' productName on which the cases will be generated</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.MicrosoftSecurityProductNameTypeConverter))]
    public partial struct MicrosoftSecurityProductName :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Microsoft Cloud App Security".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Microsoft Cloud App Security'", "Microsoft Cloud App Security", global::System.Management.Automation.CompletionResultType.ParameterValue, "Microsoft Cloud App Security");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Azure Security Center".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Azure Security Center'", "Azure Security Center", global::System.Management.Automation.CompletionResultType.ParameterValue, "Azure Security Center");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Azure Advanced Threat Protection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Azure Advanced Threat Protection'", "Azure Advanced Threat Protection", global::System.Management.Automation.CompletionResultType.ParameterValue, "Azure Advanced Threat Protection");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Azure Active Directory Identity Protection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Azure Active Directory Identity Protection'", "Azure Active Directory Identity Protection", global::System.Management.Automation.CompletionResultType.ParameterValue, "Azure Active Directory Identity Protection");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Azure Security Center for IoT".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Azure Security Center for IoT'", "Azure Security Center for IoT", global::System.Management.Automation.CompletionResultType.ParameterValue, "Azure Security Center for IoT");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Office 365 Advanced Threat Protection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Office 365 Advanced Threat Protection'", "Office 365 Advanced Threat Protection", global::System.Management.Automation.CompletionResultType.ParameterValue, "Office 365 Advanced Threat Protection");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Microsoft Defender Advanced Threat Protection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Microsoft Defender Advanced Threat Protection'", "Microsoft Defender Advanced Threat Protection", global::System.Management.Automation.CompletionResultType.ParameterValue, "Microsoft Defender Advanced Threat Protection");
            }
        }
    }
}