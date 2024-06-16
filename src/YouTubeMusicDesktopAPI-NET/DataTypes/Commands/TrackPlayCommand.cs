namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class TrackPlayCommand : IQueryCommand
{
    public string Command => "track-play";

    public string? Value => null;
}