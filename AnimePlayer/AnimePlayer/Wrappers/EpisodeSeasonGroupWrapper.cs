namespace AnimePlayer.Wrappers;

public class EpisodeSeasonGroupWrapper : List<EpisodeWrapper>
{
    public string Name { get; set; }
    public EpisodeSeasonGroupWrapper(string seasonNumber, List<EpisodeWrapper> episodes): base(episodes)
    {
        Name = seasonNumber;
    }
}
