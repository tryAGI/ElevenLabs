
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason
    {
        /// <summary>
        /// 
        /// </summary>
        DefaultingToMain,
        /// <summary>
        /// 
        /// </summary>
        TrafficSplit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason value)
        {
            return value switch
            {
                TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason.DefaultingToMain => "defaulting_to_main",
                TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason.TrafficSplit => "traffic_split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason? ToEnum(string value)
        {
            return value switch
            {
                "defaulting_to_main" => TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason.DefaultingToMain,
                "traffic_split" => TransferToAgentToolResultSuccessModelInputBranchInfoVariant1DiscriminatorBranchReason.TrafficSplit,
                _ => null,
            };
        }
    }
}