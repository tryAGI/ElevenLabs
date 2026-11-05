
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum MetronomeUsageColumnFilterColumn
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
    public static class MetronomeUsageColumnFilterColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetronomeUsageColumnFilterColumn value)
        {
            return value switch
            {
                MetronomeUsageColumnFilterColumn.Actor => "actor",
                MetronomeUsageColumnFilterColumn.BillingGroupId => "billing_group_id",
                MetronomeUsageColumnFilterColumn.FiatChargeType => "fiat_charge_type",
                MetronomeUsageColumnFilterColumn.FiatCurrency => "fiat_currency",
                MetronomeUsageColumnFilterColumn.HashedXiApiKey => "hashed_xi_api_key",
                MetronomeUsageColumnFilterColumn.Model => "model",
                MetronomeUsageColumnFilterColumn.ProductType => "product_type",
                MetronomeUsageColumnFilterColumn.Region => "region",
                MetronomeUsageColumnFilterColumn.ReportingWorkspaceId => "reporting_workspace_id",
                MetronomeUsageColumnFilterColumn.RequestSource => "request_source",
                MetronomeUsageColumnFilterColumn.Surface => "surface",
                MetronomeUsageColumnFilterColumn.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetronomeUsageColumnFilterColumn? ToEnum(string value)
        {
            return value switch
            {
                "actor" => MetronomeUsageColumnFilterColumn.Actor,
                "billing_group_id" => MetronomeUsageColumnFilterColumn.BillingGroupId,
                "fiat_charge_type" => MetronomeUsageColumnFilterColumn.FiatChargeType,
                "fiat_currency" => MetronomeUsageColumnFilterColumn.FiatCurrency,
                "hashed_xi_api_key" => MetronomeUsageColumnFilterColumn.HashedXiApiKey,
                "model" => MetronomeUsageColumnFilterColumn.Model,
                "product_type" => MetronomeUsageColumnFilterColumn.ProductType,
                "region" => MetronomeUsageColumnFilterColumn.Region,
                "reporting_workspace_id" => MetronomeUsageColumnFilterColumn.ReportingWorkspaceId,
                "request_source" => MetronomeUsageColumnFilterColumn.RequestSource,
                "surface" => MetronomeUsageColumnFilterColumn.Surface,
                "user_id" => MetronomeUsageColumnFilterColumn.UserId,
                _ => null,
            };
        }
    }
}