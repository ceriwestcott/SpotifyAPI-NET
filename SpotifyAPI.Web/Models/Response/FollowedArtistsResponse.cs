namespace SpotifyAPI.Web
{
  public class FollowedArtistsResponse
  {
    public CursorPaging<FullArtist> Artists { get; set; } = default!;
  }
}

