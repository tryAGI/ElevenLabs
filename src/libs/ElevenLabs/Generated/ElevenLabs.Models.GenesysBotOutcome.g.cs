
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Exit branch taken when the Genesys Bot Connector session ends.<br/>
    /// These values are the intent names registered in the Genesys bot list, so they are<br/>
    /// what the Call Bot Connector node branches on. Adding a value here without also<br/>
    /// registering the intent in Genesys would produce an exit the flow cannot handle.
    /// </summary>
    public enum GenesysBotOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Escalate,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenesysBotOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenesysBotOutcome value)
        {
            return value switch
            {
                GenesysBotOutcome.Escalate => "escalate",
                GenesysBotOutcome.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenesysBotOutcome? ToEnum(string value)
        {
            return value switch
            {
                "escalate" => GenesysBotOutcome.Escalate,
                "success" => GenesysBotOutcome.Success,
                _ => null,
            };
        }
    }
}