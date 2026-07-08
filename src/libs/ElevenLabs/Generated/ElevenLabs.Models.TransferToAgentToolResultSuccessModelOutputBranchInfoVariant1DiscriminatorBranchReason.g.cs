
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason
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
    public static class TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason value)
        {
            return value switch
            {
                TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason.DefaultingToMain => "defaulting_to_main",
                TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason.TrafficSplit => "traffic_split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason? ToEnum(string value)
        {
            return value switch
            {
                "defaulting_to_main" => TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason.DefaultingToMain,
                "traffic_split" => TransferToAgentToolResultSuccessModelOutputBranchInfoVariant1DiscriminatorBranchReason.TrafficSplit,
                _ => null,
            };
        }
    }
}