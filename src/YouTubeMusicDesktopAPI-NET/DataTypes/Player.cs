namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes;

public class Player
{
    public bool HasSong { get; set; }

    public bool IsPaused { get; set; }

    public int VolumePercentage { get; set; }

    public int SeekbarCurrentPosition { get; set; }

    public string SeekbarCurrentPositionHuman { get; set; } = string.Empty;

    public double StatePercent { get; set; }

    public string? LikeStatus { get; set; }

    public string? RepeatType { get; set; }
}