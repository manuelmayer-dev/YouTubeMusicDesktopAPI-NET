namespace YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;

public interface IQueryCommand
{
    string Command { get; }
    
    string? Value { get; }
}