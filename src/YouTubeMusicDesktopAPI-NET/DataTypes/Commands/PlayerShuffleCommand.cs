namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class PlayerShuffleCommand : IQueryCommand
{
    public string Command => "player-shuffle";

    public string? Value => null;
}