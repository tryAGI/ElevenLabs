
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How to break down the information. Cannot be "user" or "api_key" if include_workspace_metrics is False.
    /// </summary>
    public enum BreakdownTypes
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Voice,
        /// <summary>
        /// 
        /// </summary>
        VoiceMultiplier,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Groups,
        /// <summary>
        /// 
        /// </summary>
        ApiKeys,
        /// <summary>
        /// 
        /// </summary>
        AllApiKeys,
        /// <summary>
        /// 
        /// </summary>
        ProductType,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Resource,
        /// <summary>
        /// 
        /// </summary>
        RequestQueue,
        /// <summary>
        /// 
        /// </summary>
        Region,
        /// <summary>
        /// 
        /// </summary>
        SubresourceId,
        /// <summary>
        /// 
        /// </summary>
        ReportingWorkspaceId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BreakdownTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BreakdownTypes value)
        {
            return value switch
            {
                BreakdownTypes.None => "none",
                BreakdownTypes.Voice => "voice",
                BreakdownTypes.VoiceMultiplier => "voice_multiplier",
                BreakdownTypes.User => "user",
                BreakdownTypes.Groups => "groups",
                BreakdownTypes.ApiKeys => "api_keys",
                BreakdownTypes.AllApiKeys => "all_api_keys",
                BreakdownTypes.ProductType => "product_type",
                BreakdownTypes.Model => "model",
                BreakdownTypes.Resource => "resource",
                BreakdownTypes.RequestQueue => "request_queue",
                BreakdownTypes.Region => "region",
                BreakdownTypes.SubresourceId => "subresource_id",
                BreakdownTypes.ReportingWorkspaceId => "reporting_workspace_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BreakdownTypes? ToEnum(string value)
        {
            return value switch
            {
                "none" => BreakdownTypes.None,
                "voice" => BreakdownTypes.Voice,
                "voice_multiplier" => BreakdownTypes.VoiceMultiplier,
                "user" => BreakdownTypes.User,
                "groups" => BreakdownTypes.Groups,
                "api_keys" => BreakdownTypes.ApiKeys,
                "all_api_keys" => BreakdownTypes.AllApiKeys,
                "product_type" => BreakdownTypes.ProductType,
                "model" => BreakdownTypes.Model,
                "resource" => BreakdownTypes.Resource,
                "request_queue" => BreakdownTypes.RequestQueue,
                "region" => BreakdownTypes.Region,
                "subresource_id" => BreakdownTypes.SubresourceId,
                "reporting_workspace_id" => BreakdownTypes.ReportingWorkspaceId,
                _ => null,
            };
        }
    }
}