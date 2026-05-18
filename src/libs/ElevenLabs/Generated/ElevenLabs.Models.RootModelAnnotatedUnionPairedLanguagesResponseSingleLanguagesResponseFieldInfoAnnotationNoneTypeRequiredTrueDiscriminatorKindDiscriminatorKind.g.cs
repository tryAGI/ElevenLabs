
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        Pair,
        /// <summary>
        /// 
        /// </summary>
        Single,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind value)
        {
            return value switch
            {
                RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind.Pair => "pair",
                RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind.Single => "single",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "pair" => RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind.Pair,
                "single" => RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind.Single,
                _ => null,
            };
        }
    }
}