using AnimePlayer.Wrappers;

namespace AnimePlayer.Services.Interfaces;

public interface ITitleService
{
    Task<IEnumerable<TitleWrapper>> GetTitles();
    Task<TitleWrapper> GetTitle(long id);
}
