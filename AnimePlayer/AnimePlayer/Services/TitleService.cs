using AnimePlayer.Commons;
using AnimePlayer.DTOs;
using AnimePlayer.Services.Interfaces;
using AnimePlayer.Wrappers;
using CsharpTools.Services;
using CsharpTools.Services.Interfaces;

namespace AnimePlayer.Services;

public class TitleService : ITitleService
{
    private readonly IHttpService _httpService;

    public TitleService(IHttpService httpService)
    {
        _httpService = httpService;
    }

    public async Task<TitleWrapper> GetTitle(long id)
    {
        var url = $"{Constants.WatchModeTitleEndPoint}/{id}/details{Constants.WatchModeApiKey}&append_to_response=episodes";
        var httpResult = await _httpService.SendHttpRequest<WatchModeDTODown.WatchModeDTODownTitle>(url, HttpMethod.Get);
        return new TitleWrapper(httpResult.Content);
    }

    public async Task<IEnumerable<TitleWrapper>> GetTitles()
    {
        var url = $"{Constants.WatchModeTitlesEndPoint}{Constants.WatchModeApiKey}&limit=10";
        var httpResult = await _httpService.SendHttpRequest<WatchModeDTODown.WatchModeDTODownRoot>(url, HttpMethod.Get);
        return httpResult.Content.Titles.Select(t => new TitleWrapper(t));
    }
}
