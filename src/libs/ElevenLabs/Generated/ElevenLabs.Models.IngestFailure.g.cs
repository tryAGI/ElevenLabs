
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Why a run failed, as a bounded taxonomy.<br/>
    /// Set explicitly at each raise site rather than recovered from the message<br/>
    /// text, so rewording a user-facing string cannot silently reshape the metric.<br/>
    /// The ``UPSTREAM_*`` causes are the exception: an unclassified escape is<br/>
    /// sorted by its type in ``ScrapeRun.failed``, so a dependency outage (the<br/>
    /// agents knowledge-base routes, the sandbox) is not filed as ``UNKNOWN``.
    /// </summary>
    public enum IngestFailure
    {
        /// <summary>
        ///
        /// </summary>
        AccessRefused,
        /// <summary>
        ///
        /// </summary>
        BlockedUrl,
        /// <summary>
        ///
        /// </summary>
        CrawlTimeout,
        /// <summary>
        ///
        /// </summary>
        DnsFailure,
        /// <summary>
        ///
        /// </summary>
        HostUnreachable,
        /// <summary>
        ///
        /// </summary>
        NoContent,
        /// <summary>
        ///
        /// </summary>
        NoPages,
        /// <summary>
        ///
        /// </summary>
        Unknown,
        /// <summary>
        ///
        /// </summary>
        UpstreamError,
        /// <summary>
        ///
        /// </summary>
        UpstreamTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestFailureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestFailure value)
        {
            return value switch
            {
                IngestFailure.AccessRefused => "access_refused",
                IngestFailure.BlockedUrl => "blocked_url",
                IngestFailure.CrawlTimeout => "crawl_timeout",
                IngestFailure.DnsFailure => "dns_failure",
                IngestFailure.HostUnreachable => "host_unreachable",
                IngestFailure.NoContent => "no_content",
                IngestFailure.NoPages => "no_pages",
                IngestFailure.Unknown => "unknown",
                IngestFailure.UpstreamError => "upstream_error",
                IngestFailure.UpstreamTimeout => "upstream_timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestFailure? ToEnum(string value)
        {
            return value switch
            {
                "access_refused" => IngestFailure.AccessRefused,
                "blocked_url" => IngestFailure.BlockedUrl,
                "crawl_timeout" => IngestFailure.CrawlTimeout,
                "dns_failure" => IngestFailure.DnsFailure,
                "host_unreachable" => IngestFailure.HostUnreachable,
                "no_content" => IngestFailure.NoContent,
                "no_pages" => IngestFailure.NoPages,
                "unknown" => IngestFailure.Unknown,
                "upstream_error" => IngestFailure.UpstreamError,
                "upstream_timeout" => IngestFailure.UpstreamTimeout,
                _ => null,
            };
        }
    }
}