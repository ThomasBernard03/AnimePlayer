namespace AnimePlayer.Wrappers.Interfaces;

public interface IEpisodeWrapper
{
    int Id { get; set; }
    string Name { get; set; }
    int EpisodeNumber { get; set; }
    int? SeasonNumber { get; set; }
    string ThumbnailUrl { get; set; }
    string ReleaseDate { get; set; }
    string Description { get; set; }
}
