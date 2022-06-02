using AnimePlayer.Wrappers.Interfaces;
using Newtonsoft.Json;

namespace AnimePlayer.DTOs;

public class WatchModeDTODown
{
    public class WatchModeDTODownRoot
    {
        [JsonProperty("titles")]
        public List<WatchModeDTODownTitle> Titles { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }


    public class WatchModeDTODownTitle 
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("plot_overview")]
        public string Description { get; set; }

        [JsonProperty("user_rating")]
        public double Rating { get; set; }

        [JsonProperty("poster")]
        public string ImageUrl { get; set; }

        [JsonProperty("backdrop")]
        public string BackgroundImageUrl { get; set; }
        [JsonProperty("episodes")]
        public IEnumerable<WatchModeDTODownEpisode> Episodes { get; set; }
    }

    public class WatchModeDTODownEpisode : IEpisodeWrapper
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("episode_number")]
        public int EpisodeNumber { get; set; }

        [JsonProperty("season_number")]
        public int? SeasonNumber { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("overview")]
        public string Description { get; set; }
    }
}
