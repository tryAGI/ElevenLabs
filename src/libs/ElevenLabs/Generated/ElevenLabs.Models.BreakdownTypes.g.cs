
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
        User,
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
                BreakdownTypes.User => "user",
                BreakdownTypes.ApiKeys => "api_keys",
                BreakdownTypes.AllApiKeys => "all_api_keys",
                BreakdownTypes.ProductType => "product_type",
                BreakdownTypes.Model => "model",
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
                "user" => BreakdownTypes.User,
                "api_keys" => BreakdownTypes.ApiKeys,
                "all_api_keys" => BreakdownTypes.AllApiKeys,
                "product_type" => BreakdownTypes.ProductType,
                "model" => BreakdownTypes.Model,
                _ => null,
            };
        }
    }
}