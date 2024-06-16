namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class TrackThumbsUpCommand : IQueryCommand
{
    public string Command => "track-thumbs-up";
    
    public string? Value => null;
}