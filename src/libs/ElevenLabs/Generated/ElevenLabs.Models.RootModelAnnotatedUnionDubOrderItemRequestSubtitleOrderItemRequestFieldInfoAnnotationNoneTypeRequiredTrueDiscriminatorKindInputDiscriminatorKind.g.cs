
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        Dub,
        /// <summary>
        /// 
        /// </summary>
        Subtitles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKind value)
        {
            return value switch
            {
                RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKind.Dub => "dub",
                RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKind.Subtitles => "subtitles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "dub" => RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKind.Dub,
                "subtitles" => RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKind.Subtitles,
                _ => null,
            };
        }
    }
}