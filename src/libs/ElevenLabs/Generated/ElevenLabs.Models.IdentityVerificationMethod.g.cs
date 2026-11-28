
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum IdentityVerificationMethod
    {
        /// <summary>
        ///
        /// </summary>
        ChallengeVerified,
        /// <summary>
        ///
        /// </summary>
        ProviderAsserted,
        /// <summary>
        ///
        /// </summary>
        Unverified,
        /// <summary>
        ///
        /// </summary>
        WorkspaceAsserted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentityVerificationMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityVerificationMethod value)
        {
            return value switch
            {
                IdentityVerificationMethod.ChallengeVerified => "challenge_verified",
                IdentityVerificationMethod.ProviderAsserted => "provider_asserted",
                IdentityVerificationMethod.Unverified => "unverified",
                IdentityVerificationMethod.WorkspaceAsserted => "workspace_asserted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityVerificationMethod? ToEnum(string value)
        {
            return value switch
            {
                "challenge_verified" => IdentityVerificationMethod.ChallengeVerified,
                "provider_asserted" => IdentityVerificationMethod.ProviderAsserted,
                "unverified" => IdentityVerificationMethod.Unverified,
                "workspace_asserted" => IdentityVerificationMethod.WorkspaceAsserted,
                _ => null,
            };
        }
    }
}