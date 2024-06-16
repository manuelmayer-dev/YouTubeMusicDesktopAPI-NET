namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class TrackPauseCommand : IQueryCommand
{
    public string Command => "track-pause";

    public string? Value => null;
}