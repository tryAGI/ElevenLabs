
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExternalSyncJobTrigger
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        OnConnect,
        /// <summary>
        /// 
        /// </summary>
        OnDemand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalSyncJobTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalSyncJobTrigger value)
        {
            return value switch
            {
                ExternalSyncJobTrigger.Auto => "auto",
                ExternalSyncJobTrigger.OnConnect => "on_connect",
                ExternalSyncJobTrigger.OnDemand => "on_demand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalSyncJobTrigger? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ExternalSyncJobTrigger.Auto,
                "on_connect" => ExternalSyncJobTrigger.OnConnect,
                "on_demand" => ExternalSyncJobTrigger.OnDemand,
                _ => null,
            };
        }
    }
}