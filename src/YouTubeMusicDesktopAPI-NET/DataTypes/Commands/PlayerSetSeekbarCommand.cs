namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class PlayerSetSeekbarCommand : IQueryCommand
{
    public string Command => "player-set-seekbar";
    
    public string Value { get; }

    public PlayerSetSeekbarCommand(int seekbarProgress)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(seekbarProgress);

        Value = seekbarProgress.ToString();
    }
}