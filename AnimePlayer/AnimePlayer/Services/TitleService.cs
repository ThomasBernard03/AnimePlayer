using AnimePlayer.Commons;
using AnimePlayer.DTOs;
using AnimePlayer.Services.Interfaces;
using AnimePlayer.Wrappers;
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
        //var url = $"{Constants.WatchModeTitleEndPoint}/{id}/details{Constants.WatchModeApiKey}&append_to_response=episodes";
        //var httpResult = await _httpService.SendHttpRequest<GhibliTitleDTO>(url, HttpMethod.Get);
        //return new TitleWrapper(httpResult.Content);
        return new TitleWrapper();
    }

    public async Task<IEnumerable<TitleWrapper>> GetTitles()
    {
        var httpResult = await _httpService.SendHttpRequest<IEnumerable<GhibliTitleDTO>>(Constants.GhibliApiTitlesEndPoint, HttpMethod.Get);
        return httpResult.Content?.Select(t => new TitleWrapper(t));
    }
}
