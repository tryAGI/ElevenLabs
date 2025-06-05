
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Sort criteria. Can be one of: created_date, download_count, like_count, trending_score. Defaults to trending_score.<br/>
    /// Default Value: trending_score<br/>
    /// Example: trending_score
    /// </summary>
    public enum GetSharedSoundEffectsV1SharedSoundGenerationsGetSort
    {
        /// <summary>
        /// 
        /// </summary>
        SharingDateUnix,
        /// <summary>
        /// 
        /// </summary>
        PurchasedCount,
        /// <summary>
        /// created_date, download_count, like_count, trending_score. Defaults to trending_score.
        /// </summary>
        LikeCount,
        /// <summary>
        /// created_date, download_count, like_count, trending_score. Defaults to trending_score.
        /// </summary>
        TrendingScore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSharedSoundEffectsV1SharedSoundGenerationsGetSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSharedSoundEffectsV1SharedSoundGenerationsGetSort value)
        {
            return value switch
            {
                GetSharedSoundEffectsV1SharedSoundGenerationsGetSort.SharingDateUnix => "sharing_date_unix",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetSort.PurchasedCount => "purchased_count",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetSort.LikeCount => "like_count",
                GetSharedSoundEffectsV1SharedSoundGenerationsGetSort.TrendingScore => "trending_score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSharedSoundEffectsV1SharedSoundGenerationsGetSort? ToEnum(string value)
        {
            return value switch
            {
                "sharing_date_unix" => GetSharedSoundEffectsV1SharedSoundGenerationsGetSort.SharingDateUnix,
                "purchased_count" => GetSharedSoundEffectsV1SharedSoundGenerationsGetSort.PurchasedCount,
                "like_count" => GetSharedSoundEffectsV1SharedSoundGenerationsGetSort.LikeCount,
                "trending_score" => GetSharedSoundEffectsV1SharedSoundGenerationsGetSort.TrendingScore,
                _ => null,
            };
        }
    }
}