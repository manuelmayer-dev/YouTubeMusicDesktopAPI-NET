namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes;

public class Lyrics
{
    public string Provider { get; set; } = string.Empty;

    public string Data { get; set; } = string.Empty;

    public bool HasLoaded { get; set; }
}