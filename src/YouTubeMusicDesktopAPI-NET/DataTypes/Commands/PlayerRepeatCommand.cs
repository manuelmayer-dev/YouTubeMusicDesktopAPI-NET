using YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Enums;

namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class PlayerRepeatCommand : IQueryCommand
{
    public string Command => "player-repeat";

    public string? Value => null;
}