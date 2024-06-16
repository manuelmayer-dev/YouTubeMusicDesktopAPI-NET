using System.Net;
using YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Enums;

namespace YouTubeMusicDesktopAPI_NET.DataTypes.Exceptions;

public class YouTubeMusicDesktopException : Exception
{
    public YouTubeMusicDesktopError Error { get; }

    public HttpStatusCode? StatusCode { get; set; }

    public Exception? Exception { get; set; }

public YouTubeMusicDesktopException(YouTubeMusicDesktopError error)
    {
        Error = error;
    }

    public YouTubeMusicDesktopException(YouTubeMusicDesktopError error, HttpStatusCode? statusCode)
    {
        Error = error;
        StatusCode = statusCode;
    }

    public YouTubeMusicDesktopException(YouTubeMusicDesktopError error, Exception exception)
    {
        Error = error;
        Exception = exception;
    }
}