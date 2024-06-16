namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class PlayerRewindCommand : IQueryCommand
{
    public string Command => "player-rewind";
    
    public string? Value => null;
}