
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item
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
    public static class BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item value)
        {
            return value switch
            {
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.BillingGroupId => "billing_group_id",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.FiatChargeType => "fiat_charge_type",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.FiatCurrency => "fiat_currency",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.HashedXiApiKey => "hashed_xi_api_key",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.Model => "model",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ProductType => "product_type",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.Region => "region",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ReportingWorkspaceId => "reporting_workspace_id",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.RequestQueueType => "request_queue_type",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.RequestSource => "request_source",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ResourceId => "resource_id",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.SubresourceId => "subresource_id",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.UserId => "user_id",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.VoiceId => "voice_id",
                BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.VoiceMultiplier => "voice_multiplier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "billing_group_id" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.BillingGroupId,
                "fiat_charge_type" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.FiatChargeType,
                "fiat_currency" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.FiatCurrency,
                "hashed_xi_api_key" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.HashedXiApiKey,
                "model" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.Model,
                "product_type" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ProductType,
                "region" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.Region,
                "reporting_workspace_id" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ReportingWorkspaceId,
                "request_queue_type" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.RequestQueueType,
                "request_source" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.RequestSource,
                "resource_id" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.ResourceId,
                "subresource_id" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.SubresourceId,
                "user_id" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.UserId,
                "voice_id" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.VoiceId,
                "voice_multiplier" => BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item.VoiceMultiplier,
                _ => null,
            };
        }
    }
}