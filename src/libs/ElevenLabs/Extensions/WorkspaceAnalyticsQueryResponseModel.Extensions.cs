#nullable enable

using System.Globalization;

namespace ElevenLabs;

/// <summary>A UTC-day credit total from ElevenLabs workspace analytics.</summary>
public sealed record WorkspaceCreditUsage(DateOnly Day, double Credits);

/// <summary>Helpers for consuming ElevenLabs' column-oriented workspace analytics responses.</summary>
public static class WorkspaceAnalyticsQueryResponseModelExtensions
{
    /// <summary>
    /// Aggregates product-level workspace usage rows into UTC-day credit totals. The API has
    /// used both <c>credits_used</c> and <c>total_charge_count</c> for the credit column, so this
    /// helper also falls back to the unique numeric column whose unit is <c>credits</c>.
    /// </summary>
    public static IReadOnlyList<WorkspaceCreditUsage> GetCreditUsageByUtcDay(
        this WorkspaceAnalyticsQueryResponseModel response)
    {
        ArgumentNullException.ThrowIfNull(response);

        var timestampIndex = FindRequiredColumn(response.Columns, "timestamp");
        var creditsIndex = FindCreditsColumn(response);
        var requiredRowLength = Math.Max(timestampIndex, creditsIndex) + 1;
        var creditsByDay = new SortedDictionary<DateOnly, double>();

        foreach (var row in response.Rows)
        {
            if (row.Count < requiredRowLength)
            {
                throw new InvalidDataException(
                    $"ElevenLabs workspace usage row had {row.Count} values for {response.Columns.Count} columns.");
            }

            var day = DateOnly.FromDateTime(ReadTimestamp(row[timestampIndex]).UtcDateTime);
            creditsByDay[day] = creditsByDay.GetValueOrDefault(day) + ReadDouble(row[creditsIndex]);
        }

        return creditsByDay
            .Select(static pair => new WorkspaceCreditUsage(pair.Key, pair.Value))
            .ToArray();
    }

    private static int FindCreditsColumn(WorkspaceAnalyticsQueryResponseModel response)
    {
        foreach (var columnName in new[] { "credits_used", "total_charge_count" })
        {
            var namedIndex = FindColumn(response.Columns, columnName);
            if (namedIndex >= 0)
            {
                return namedIndex;
            }
        }

        if (response.ColumnTypes.Count == response.Columns.Count &&
            response.ColumnUnits.Count == response.Columns.Count)
        {
            var metadataMatches = Enumerable.Range(0, response.Columns.Count)
                .Where(index =>
                    response.ColumnUnits[index] == ColumnUnit.Credits &&
                    response.ColumnTypes[index] is
                        WorkspaceAnalyticsQueryResponseModelColumnType.Float or
                        WorkspaceAnalyticsQueryResponseModelColumnType.Int)
                .ToArray();

            if (metadataMatches.Length == 1)
            {
                return metadataMatches[0];
            }
        }

        throw new InvalidDataException(
            $"ElevenLabs workspace usage response did not include one numeric credits column. " +
            $"Columns: [{string.Join(", ", response.Columns)}].");
    }

    private static int FindRequiredColumn(IList<string> columns, string columnName)
    {
        var index = FindColumn(columns, columnName);
        return index >= 0
            ? index
            : throw new InvalidDataException(
                $"ElevenLabs workspace usage response did not include the '{columnName}' column.");
    }

    private static int FindColumn(IList<string> columns, string columnName)
    {
        for (var index = 0; index < columns.Count; index++)
        {
            if (string.Equals(columns[index], columnName, StringComparison.OrdinalIgnoreCase))
            {
                return index;
            }
        }

        return -1;
    }

    private static DateTimeOffset ReadTimestamp(
        AnyOf<string, int?, double?, bool?, DateTime?, object> value)
    {
        if (value.Value5 is DateTime dateTime)
        {
            return new DateTimeOffset(DateTime.SpecifyKind(dateTime, DateTimeKind.Utc));
        }

        if (value.Value1 is string text && DateTimeOffset.TryParse(
                text,
                CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal,
                out var parsed))
        {
            return parsed;
        }

        throw new InvalidDataException(
            $"ElevenLabs workspace usage timestamp '{value}' was not an ISO-8601 value.");
    }

    private static double ReadDouble(
        AnyOf<string, int?, double?, bool?, DateTime?, object> value)
    {
        if (value.Value3 is double doubleValue)
        {
            return doubleValue;
        }

        if (value.Value2 is int intValue)
        {
            return intValue;
        }

        if (value.Value1 is string text && double.TryParse(
                text,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out var parsed))
        {
            return parsed;
        }

        throw new InvalidDataException(
            $"ElevenLabs workspace usage credits value '{value}' was not numeric.");
    }
}
