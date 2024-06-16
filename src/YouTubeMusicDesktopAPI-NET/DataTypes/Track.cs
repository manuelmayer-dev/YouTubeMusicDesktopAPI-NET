namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes;

public class Track
{
    public string Author { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Album { get; set; } = string.Empty;

    public string Cover { get; set; } = string.Empty;
    
    public int Duration { get; set; }

    public string DurationHuman { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    public string Id { get; set; } = string.Empty;

    public bool IsVideo { get; set; }

    public bool IsAdvertisement { get; set; }

    public bool InLibrary { get; set; }
}