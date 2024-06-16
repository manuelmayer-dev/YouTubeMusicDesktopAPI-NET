namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class PlayerAddLibraryCommand : IQueryCommand
{
    public string Command => "player-add-library";

    public string? Value => null;
}