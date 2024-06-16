using YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Enums;
using YouTubeMusicDesktopAPI_NET.DataTypes.Exceptions;

namespace YouTubeMusicDesktopAPI_NET.DataTypes.Extensions;

public static class YouTubeMusicDesktopExceptionExtensions
{
    public static void ThrowNoResponseIfNull(this object? obj)
    {
        if (obj is null)
        {
            throw new YouTubeMusicDesktopException(YouTubeMusicDesktopError.NoResponse);
        }
    }
}