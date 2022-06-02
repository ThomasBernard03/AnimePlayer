using AnimePlayer.DTOs;
using AnimePlayer.Wrappers.Interfaces;

namespace AnimePlayer.Wrappers;

public class TitleWrapper
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string BackgroundImageUrl { get; set; }
    public double Rating { get; set; }
    public int Year { get; set; }
    public IEnumerable<EpisodeWrapper> Episodes { get; set; }

    public TitleWrapper()
    {
    }

    public TitleWrapper(WatchModeDTODown.WatchModeDTODownTitle watchModeDTODownTitle)
    {
        Id = watchModeDTODownTitle.Id;
        Name = watchModeDTODownTitle.Name;
        Description = watchModeDTODownTitle.Description;
        ImageUrl = watchModeDTODownTitle.ImageUrl;
        BackgroundImageUrl = watchModeDTODownTitle.BackgroundImageUrl;
        Rating = watchModeDTODownTitle.Rating;
        Year = watchModeDTODownTitle.Year;
        Episodes = watchModeDTODownTitle.Episodes?.Select(e => new EpisodeWrapper(e));
    }
}
