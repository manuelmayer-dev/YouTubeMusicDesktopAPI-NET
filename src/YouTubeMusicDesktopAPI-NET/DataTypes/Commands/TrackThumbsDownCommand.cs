namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class TrackThumbsDownCommand : IQueryCommand
{
    public string Command => "track-thumbs-down";

    public string? Value => null;
}