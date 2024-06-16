namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class PlayerVolumeUpCommand : IQueryCommand
{
    public string Command => "player-volume-up";

    public string? Value => null;
}