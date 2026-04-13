
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        BillingGroupId,
        /// <summary>
        /// 
        /// </summary>
        FiatChargeType,
        /// <summary>
        /// 
        /// </summary>
        FiatCurrency,
        /// <summary>
        /// 
        /// </summary>
        HashedXiApiKey,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        ProductType,
        /// <summary>
        /// 
        /// </summary>
        Region,
        /// <summary>
        /// 
        /// </summary>
        ReportingWorkspaceId,
        /// <summary>
        /// 
        /// </summary>
        RequestQueueType,
        /// <summary>
        /// 
        /// </summary>
        RequestSource,
        /// <summary>
        /// 
        /// </summary>
        ResourceId,
        /// <summary>
        /// 
        /// </summary>
        SubresourceId,
        /// <summary>
        /// 
        /// </summary>
        UserId,
        /// <summary>
        /// 
        /// </summary>
        VoiceId,
        /// <summary>
        /// 
        /// </summary>
        VoiceMultiplier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item value)
        {
            return value switch
            {
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.BillingGroupId => "billing_group_id",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.FiatChargeType => "fiat_charge_type",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.FiatCurrency => "fiat_currency",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.HashedXiApiKey => "hashed_xi_api_key",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.Model => "model",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ProductType => "product_type",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.Region => "region",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ReportingWorkspaceId => "reporting_workspace_id",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.RequestQueueType => "request_queue_type",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.RequestSource => "request_source",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ResourceId => "resource_id",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.SubresourceId => "subresource_id",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.UserId => "user_id",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.VoiceId => "voice_id",
                BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.VoiceMultiplier => "voice_multiplier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "billing_group_id" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.BillingGroupId,
                "fiat_charge_type" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.FiatChargeType,
                "fiat_currency" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.FiatCurrency,
                "hashed_xi_api_key" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.HashedXiApiKey,
                "model" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.Model,
                "product_type" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ProductType,
                "region" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.Region,
                "reporting_workspace_id" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ReportingWorkspaceId,
                "request_queue_type" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.RequestQueueType,
                "request_source" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.RequestSource,
                "resource_id" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ResourceId,
                "subresource_id" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.SubresourceId,
                "user_id" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.UserId,
                "voice_id" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.VoiceId,
                "voice_multiplier" => BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.VoiceMultiplier,
                _ => null,
            };
        }
    }
}