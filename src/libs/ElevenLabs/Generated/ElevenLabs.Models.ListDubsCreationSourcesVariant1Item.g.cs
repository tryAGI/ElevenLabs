
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDubsCreationSourcesVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        DubbingApi,
        /// <summary>
        /// 
        /// </summary>
        DubbingUi,
        /// <summary>
        /// 
        /// </summary>
        FlowNode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDubsCreationSourcesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDubsCreationSourcesVariant1Item value)
        {
            return value switch
            {
                ListDubsCreationSourcesVariant1Item.DubbingApi => "dubbing_api",
                ListDubsCreationSourcesVariant1Item.DubbingUi => "dubbing_ui",
                ListDubsCreationSourcesVariant1Item.FlowNode => "flow_node",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDubsCreationSourcesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "dubbing_api" => ListDubsCreationSourcesVariant1Item.DubbingApi,
                "dubbing_ui" => ListDubsCreationSourcesVariant1Item.DubbingUi,
                "flow_node" => ListDubsCreationSourcesVariant1Item.FlowNode,
                _ => null,
            };
        }
    }
}