using YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes;

namespace YouTubeMusicDesktopAPI_NET.DataTypes;

public interface IYouTubeMusicDesktopPlayer
{
    /// <summary>
    /// Checks the configured password
    /// </summary>
    Task<bool> CheckPassword();
    
    /// <summary>
    /// Downloads the album art
    /// </summary>
    /// <param name="size">Size in px</param>
    Task<byte[]> DownloadAlbumArt(int size = 300);
    
    /// <summary>
    /// Get info about player and track
    /// </summary>
    Task<Query> GetQuery();

    /// <summary>
    /// Get info about player
    /// </summary>
    Task<Player> GetPlayer();

    /// <summary>
    /// Get info about track
    /// </summary>
    Task<Track> GetTrack();

    /// <summary>
    /// Get info about lyrics
    /// </summary>
    Task<Lyrics> GetLyrics();

    /// <summary>
    /// Get info about playlists
    /// </summary>
    Task<Playlist> GetPlaylist();

    /// <summary>
    /// Get info about queue
    /// </summary>
    Task<Queue> GetQueue();

    /// <summary>
    /// Play music
    /// </summary>
    Task PlayMusic();

    /// <summary>
    /// Pause music
    /// </summary>
    Task PauseMusic();

    /// <summary>
    /// Next track
    /// </summary>
    Task PlayNextTrack();
    
    /// <summary>
    /// Previous track
    /// </summary>
    Task PlayPreviousTrack();

    /// <summary>
    /// Like current track
    /// </summary>
    Task ThumbsUp();
    
    /// <summary>
    /// Dislike current track
    /// </summary>
    Task ThumbsDown();

    /// <summary>
    /// Increase the player volume
    /// </summary>
    Task VolumeUp();

    /// <summary>
    /// Decrease the player volume
    /// </summary>
    Task VolumeDown();

    /// <summary>
    /// Forward 10 seconds
    /// </summary>
    Task Forward();
    
    /// <summary>
    /// Rewind 10 seconds
    /// </summary>
    Task Rewind();

    /// <summary>
    /// Toggle NONE or ONE or ALL
    /// </summary>
    Task SetRepeat();

    /// <summary>
    /// Shuffle queue
    /// </summary>
    Task Shuffle();

    /// <summary>
    /// Add track to library
    /// </summary>
    Task AddToLibrary();

    /// <summary>
    /// Add track to playlist
    /// </summary>
    /// <param name="playlistIndex">Playlist index</param>
    Task AddToPlaylist(int playlistIndex);

    /// <summary>
    /// Set value for seekbar
    /// </summary>
    /// <param name="progress">0 ~ Track duration</param>
    Task SetSeekbarProgress(int progress);

    /// <summary>
    /// Set value for volume
    /// </summary>
    /// <param name="volumePercentage">0 ~ 100</param>
    Task SetVolume(int volumePercentage);
}