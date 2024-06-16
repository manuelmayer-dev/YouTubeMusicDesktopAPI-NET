using System.ComponentModel;

namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Enums;

public enum YouTubeMusicDesktopError
{
    [Description("Received no response from the API.")]
    NoResponse,
    
    [Description("Something went wrong during the request.")]
    RequestError,
    
    [Description("An unknown error occured. See exception.")]
    UnknownError
}