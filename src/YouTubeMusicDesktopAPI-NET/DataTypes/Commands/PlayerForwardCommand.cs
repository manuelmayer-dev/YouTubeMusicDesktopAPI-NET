namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class PlayerForwardCommand : IQueryCommand
{
    public string Command => "player-forward";

    public string? Value => null;
}