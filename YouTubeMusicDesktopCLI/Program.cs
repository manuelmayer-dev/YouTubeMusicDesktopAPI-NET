using YouTubeMusicDesktopAPI_NET.DataTypes;
using YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes;

var options = new YouTubeMusicDesktopPlayerOptions(new Uri("http://localhost:9863"), "");
var youtubeMusicDesktopPlayer = new YouTubeMusicDesktopPlayer(options);

var passwordValid = await youtubeMusicDesktopPlayer.CheckPassword();
Console.WriteLine($"Password valid: {passwordValid}");

var query = await youtubeMusicDesktopPlayer.GetQuery();

Console.WriteLine($"Current playback: {query.Track?.Title} by {query.Track?.Author}");

await youtubeMusicDesktopPlayer.PlayNextTrack();

await Task.Delay(1000);

query = await youtubeMusicDesktopPlayer.GetQuery();
Console.WriteLine($"Current playback: {query.Track?.Title} by {query.Track?.Author}");