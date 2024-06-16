namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public class PlayerSetVolumeCommand : IQueryCommand
{
    public string Command => "player-set-volume";
    
    public string Value { get; }

    public PlayerSetVolumeCommand(int volumePercentage)
    {
        if (volumePercentage is < 0 or > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(volumePercentage));
        }

        Value = volumePercentage.ToString();
    }
}