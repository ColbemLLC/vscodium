using System.Net.Http;

namespace Codium.Services;

public class UpdateService
{
    private static readonly HttpClient httpClient = new();
    private const string CurrentCommitHash = "0000000000000000000000000000000000000000";

    public async Task<string> CheckForUpdateAsync()
    {
        var response = await httpClient.GetStringAsync(
            $"https://update.colbe.cc/api/update/win32-x64-archive/stable/{CurrentCommitHash}");

        return response;
    }
}
