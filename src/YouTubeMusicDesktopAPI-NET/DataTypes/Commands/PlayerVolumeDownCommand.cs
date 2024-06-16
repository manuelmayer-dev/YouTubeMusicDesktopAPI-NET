namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class PlayerVolumeDownCommand : IQueryCommand
{
    public string Command => "player-volume-down";

    public string? Value => null;
}