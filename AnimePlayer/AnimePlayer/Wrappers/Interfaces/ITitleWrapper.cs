namespace AnimePlayer.Wrappers.Interfaces;

public interface ITitleWrapper
{
    string Id { get; set; }
    string Title { get; set; }
    string OriginalTitle { get; set; }
    string OriginalTitleRomanised { get; set; }
    string Image { get; set; }
    string MovieBanner { get; set; }
    string Description { get; set; }
    string Director { get; set; }
    string Producer { get; set; }
    string ReleaseDate { get; set; }
    string RunningTime { get; set; }
    string RtScore { get; set; }
}
