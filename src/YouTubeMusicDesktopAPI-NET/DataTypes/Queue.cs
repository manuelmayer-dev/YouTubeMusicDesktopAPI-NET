namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes;

public class Queue
{
    public bool Automix { get; set; }

    public int Index { get; set; }

    public QueueItem[] List { get; set; } = [];
}