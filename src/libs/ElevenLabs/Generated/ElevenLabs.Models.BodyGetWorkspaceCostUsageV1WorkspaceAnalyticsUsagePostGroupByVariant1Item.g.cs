
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        Actor,
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
        RequestSource,
        /// <summary>
        ///
        /// </summary>
        Surface,
        /// <summary>
        ///
        /// </summary>
        UserId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item value)
        {
            return value switch
            {
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.Actor => "actor",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.BillingGroupId => "billing_group_id",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.FiatChargeType => "fiat_charge_type",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.FiatCurrency => "fiat_currency",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.HashedXiApiKey => "hashed_xi_api_key",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.Model => "model",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.ProductType => "product_type",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.Region => "region",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.ReportingWorkspaceId => "reporting_workspace_id",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.RequestSource => "request_source",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.Surface => "surface",
                BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "actor" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.Actor,
                "billing_group_id" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.BillingGroupId,
                "fiat_charge_type" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.FiatChargeType,
                "fiat_currency" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.FiatCurrency,
                "hashed_xi_api_key" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.HashedXiApiKey,
                "model" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.Model,
                "product_type" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.ProductType,
                "region" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.Region,
                "reporting_workspace_id" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.ReportingWorkspaceId,
                "request_source" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.RequestSource,
                "surface" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.Surface,
                "user_id" => BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item.UserId,
                _ => null,
            };
        }
    }
}