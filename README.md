# YouTubeMusicDesktopAPI-NET
A client for the YouTubeMusicDesktop API, written in C#/.NET

### Features

- ☑️ Download album art
- ☑️ Control playback
- ☑️ Get playback information
- ☑️ Authentication
- ☑️ No extra dependencies
- ☑️ Asynchronous

### Todo
- Write tests

### Installation
[NuGet](https://www.nuget.org/packages/ManuelMayer.YouTubeMusicDesktopAPI-NET)

### Usage

```c#
using SinusBotAPI;

class Program
{
    public static async Task Main(string[] args)
    {
        var options = new YouTubeMusicDesktopPlayerOptions(new Uri("http://localhost:9863"), "");
        var youtubeMusicDesktopPlayer = new YouTubeMusicDesktopPlayer(options);
        
        var passwordValid = await youtubeMusicDesktopPlayer.CheckPassword();
        Console.WriteLine($"Password valid: {passwordValid}");
        
        var query = await youtubeMusicDesktopPlayer.GetQuery();
        
        Console.WriteLine($"Current playback: {query.Track?.Title} by {query.Track?.Author}");
        
        await youtubeMusicDesktopPlayer.PlayNextTrack();
    }    
}
```
