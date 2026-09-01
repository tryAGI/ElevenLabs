#nullable enable

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void WorkspaceAnalytics_AggregatesProductRowsAndColumnDrift()
    {
        var response = new WorkspaceAnalyticsQueryResponseModel
        {
            Columns = ["product", "timestamp", "total_charge_count"],
            ColumnTypes =
            [
                WorkspaceAnalyticsQueryResponseModelColumnType.String,
                WorkspaceAnalyticsQueryResponseModelColumnType.DateTime,
                WorkspaceAnalyticsQueryResponseModelColumnType.Float,
            ],
            ColumnUnits = [ColumnUnit.S, ColumnUnit.S, ColumnUnit.Credits],
            Rows =
            [
                ["tts", "2026-09-01T03:00:00Z", 12.5],
                ["stt", "2026-09-01T12:00:00Z", 7.5],
                ["tts", "2026-09-02T01:00:00Z", 3],
            ],
        };

        var usage = response.GetCreditUsageByUtcDay();

        usage.Should().Equal(
            new WorkspaceCreditUsage(new DateOnly(2026, 9, 1), 20),
            new WorkspaceCreditUsage(new DateOnly(2026, 9, 2), 3));
    }

    [TestMethod]
    public void WorkspaceAnalytics_UsesUniqueCreditsMetadataColumn()
    {
        var response = new WorkspaceAnalyticsQueryResponseModel
        {
            Columns = ["timestamp", "renamed_credit_total"],
            ColumnTypes =
            [
                WorkspaceAnalyticsQueryResponseModelColumnType.DateTime,
                WorkspaceAnalyticsQueryResponseModelColumnType.Int,
            ],
            ColumnUnits = [ColumnUnit.S, ColumnUnit.Credits],
            Rows = [[new DateTime(2026, 9, 1, 0, 0, 0, DateTimeKind.Utc), 4]],
        };

        response.GetCreditUsageByUtcDay().Should().Equal(
            new WorkspaceCreditUsage(new DateOnly(2026, 9, 1), 4));
    }
}
