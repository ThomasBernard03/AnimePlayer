using AnimePlayer.Wrappers.Interfaces;

namespace AnimePlayer.Wrappers
{
    public class EpisodeWrapper : IEpisodeWrapper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EpisodeNumber { get; set; }
        public int? SeasonNumber { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ReleaseDate { get; set; }
        public string Description { get; set; }

        public EpisodeWrapper()
        {
        }

        public EpisodeWrapper(IEpisodeWrapper episodeWrapper)
        {
            Id = episodeWrapper.Id;
            Name = episodeWrapper.Name;
            EpisodeNumber = episodeWrapper.EpisodeNumber;
            SeasonNumber = episodeWrapper.SeasonNumber;
            ThumbnailUrl = episodeWrapper.ThumbnailUrl;
            ReleaseDate = episodeWrapper.ReleaseDate;
            Description = episodeWrapper.Description;
        }
    }
}
