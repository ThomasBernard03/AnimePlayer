using AnimePlayer.Wrappers.Interfaces;
using Newtonsoft.Json;

namespace AnimePlayer.DTOs;

public class GhibliTitleDTO : ITitleWrapper
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("original_title")]
    public string OriginalTitle { get; set; }

    [JsonProperty("original_title_romanised")]
    public string OriginalTitleRomanised { get; set; }

    [JsonProperty("image")]
    public string Image { get; set; }

    [JsonProperty("movie_banner")]
    public string MovieBanner { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("director")]
    public string Director { get; set; }

    [JsonProperty("producer")]
    public string Producer { get; set; }

    [JsonProperty("release_date")]
    public string ReleaseDate { get; set; }

    [JsonProperty("running_time")]
    public string RunningTime { get; set; }

    [JsonProperty("rt_score")]
    public string RtScore { get; set; }
}
