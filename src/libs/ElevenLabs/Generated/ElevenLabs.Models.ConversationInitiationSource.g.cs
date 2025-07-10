
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Enum representing the possible sources for conversation initiation.
    /// </summary>
    public enum ConversationInitiationSource
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        AndroidSdk,
        /// <summary>
        /// 
        /// </summary>
        NodeJsSdk,
        /// <summary>
        /// 
        /// </summary>
        ReactNativeSdk,
        /// <summary>
        /// 
        /// </summary>
        ReactSdk,
        /// <summary>
        /// 
        /// </summary>
        JsSdk,
        /// <summary>
        /// 
        /// </summary>
        PythonSdk,
        /// <summary>
        /// 
        /// </summary>
        Widget,
        /// <summary>
        /// 
        /// </summary>
        SipTrunk,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Genesys,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationInitiationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationInitiationSource value)
        {
            return value switch
            {
                ConversationInitiationSource.Unknown => "unknown",
                ConversationInitiationSource.AndroidSdk => "android_sdk",
                ConversationInitiationSource.NodeJsSdk => "node_js_sdk",
                ConversationInitiationSource.ReactNativeSdk => "react_native_sdk",
                ConversationInitiationSource.ReactSdk => "react_sdk",
                ConversationInitiationSource.JsSdk => "js_sdk",
                ConversationInitiationSource.PythonSdk => "python_sdk",
                ConversationInitiationSource.Widget => "widget",
                ConversationInitiationSource.SipTrunk => "sip_trunk",
                ConversationInitiationSource.Twilio => "twilio",
                ConversationInitiationSource.Genesys => "genesys",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationInitiationSource? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => ConversationInitiationSource.Unknown,
                "android_sdk" => ConversationInitiationSource.AndroidSdk,
                "node_js_sdk" => ConversationInitiationSource.NodeJsSdk,
                "react_native_sdk" => ConversationInitiationSource.ReactNativeSdk,
                "react_sdk" => ConversationInitiationSource.ReactSdk,
                "js_sdk" => ConversationInitiationSource.JsSdk,
                "python_sdk" => ConversationInitiationSource.PythonSdk,
                "widget" => ConversationInitiationSource.Widget,
                "sip_trunk" => ConversationInitiationSource.SipTrunk,
                "twilio" => ConversationInitiationSource.Twilio,
                "genesys" => ConversationInitiationSource.Genesys,
                _ => null,
            };
        }
    }
}