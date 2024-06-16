namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class TrackPreviousCommand : IQueryCommand
{
    public string Command => "track-previous";

    public string? Value => null;
}