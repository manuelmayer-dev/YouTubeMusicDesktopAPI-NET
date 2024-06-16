namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class PlayerAddPlaylistCommand : IQueryCommand
{
    public string Command => "player-add-playlist";
    
    public string Value { get; }

    public PlayerAddPlaylistCommand(int playListIndex)
    {
        Value = playListIndex.ToString();
    }
}