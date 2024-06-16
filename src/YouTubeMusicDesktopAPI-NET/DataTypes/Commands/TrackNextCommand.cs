namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class TrackNextCommand : IQueryCommand
{
    public string Command => "track-next";

    public string? Value => null;
}