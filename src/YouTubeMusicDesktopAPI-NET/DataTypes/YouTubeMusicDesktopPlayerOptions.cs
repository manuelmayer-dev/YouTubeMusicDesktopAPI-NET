namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes;

public class YouTubeMusicDesktopPlayerOptions
{
    public Uri InstanceUrl { get; set; }

    public string? Password { get; set; }

    public YouTubeMusicDesktopPlayerOptions(Uri instanceUrl, string? password = null)
    {
        InstanceUrl = instanceUrl;
        Password = password;
    }
}