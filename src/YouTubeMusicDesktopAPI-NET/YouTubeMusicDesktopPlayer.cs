using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes;
using YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Commands;
using YouTubeMusicDesktopAPI_NET.DataTypes.DataTypes.Enums;
using YouTubeMusicDesktopAPI_NET.DataTypes.Exceptions;
using YouTubeMusicDesktopAPI_NET.DataTypes.Extensions;

namespace YouTubeMusicDesktopAPI_NET.DataTypes;

public partial class YouTubeMusicDesktopPlayer : IYouTubeMusicDesktopPlayer
{
    private readonly YouTubeMusicDesktopPlayerOptions _options;
    
    public YouTubeMusicDesktopPlayer(YouTubeMusicDesktopPlayerOptions options)
    {
        _options = options;
    }

    public async Task<bool> CheckPassword()
    {
        try
        {
            await SendCommand(new CheckPasswordCommand());
            return true;
        }
        catch (YouTubeMusicDesktopException youTubeMusicDesktopException) when
            (youTubeMusicDesktopException.StatusCode is HttpStatusCode.Unauthorized)
        {
            return false;
        }
    }

    public async Task<byte[]> DownloadAlbumArt(int size = 300)
    {
        var track = await GetTrack();
        return await new HttpClient().GetByteArrayAsync(CoverSizeRegex().Replace(track.Cover, $"=w{size}-h{size}"));
    }

    public Task<Query> GetQuery()
    {
        return HandledGetRequest<Query>("query");
    }

    public Task<Player> GetPlayer()
    {
        return HandledGetRequest<Player>("query/player");
    }

    public Task<Track> GetTrack()
    {
        return HandledGetRequest<Track>("query/track");
    }

    public Task<Lyrics> GetLyrics()
    {
        return HandledGetRequest<Lyrics>("query/lyrics");
    }

    public Task<Playlist> GetPlaylist()
    {
        return HandledGetRequest<Playlist>("query/playlist");
    }

    public Task<Queue> GetQueue()
    {
        return HandledGetRequest<Queue>("query/queue");
    }

    public Task PlayMusic()
    {
        return SendCommand(new TrackPlayCommand());
    }

    public Task PauseMusic()
    {
        return SendCommand(new TrackPauseCommand());
    }

    public Task PlayNextTrack()
    {
        return SendCommand(new TrackNextCommand());
    }

    public Task PlayPreviousTrack()
    {
        return SendCommand(new TrackPreviousCommand());
    }

    public Task ThumbsUp()
    {
        return SendCommand(new TrackThumbsUpCommand());
    }

    public Task ThumbsDown()
    {
        return SendCommand(new TrackThumbsDownCommand());
    }

    public Task VolumeUp()
    {
        return SendCommand(new PlayerVolumeUpCommand());
    }

    public Task VolumeDown()
    {
        return SendCommand(new PlayerVolumeDownCommand());
    }

    public Task Forward()
    {
        return SendCommand(new PlayerForwardCommand());
    }

    public Task Rewind()
    {
        return SendCommand(new PlayerRewindCommand());
    }

    public Task SetRepeat()
    {
        return SendCommand(new PlayerRepeatCommand());
    }

    public Task Shuffle()
    {
        return SendCommand(new PlayerShuffleCommand());
    }

    public Task AddToLibrary()
    {
        return SendCommand(new PlayerAddLibraryCommand());
    }

    public Task AddToPlaylist(int playlistIndex)
    {
        return SendCommand(new PlayerAddPlaylistCommand(playlistIndex));
    }

    public Task SetSeekbarProgress(int progress)
    {
        return SendCommand(new PlayerSetSeekbarCommand(progress));
    }

    public Task SetVolume(int volumePercentage)
    {
        return SendCommand(new PlayerSetVolumeCommand(volumePercentage));
    }

    private async Task SendCommand(IQueryCommand command)
    {
        try
        {
            var json = JsonSerializer.Serialize(command, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            using StringContent jsonContent = new(json, Encoding.UTF8, "application/json");
            var result = await GetHttpClient().PostAsync("query", jsonContent);
            result.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException httpRequestException)
        {
            throw new YouTubeMusicDesktopException(YouTubeMusicDesktopError.RequestError,
                httpRequestException.StatusCode);
        }
        catch (Exception ex)
        {
            throw new YouTubeMusicDesktopException(
                YouTubeMusicDesktopError.UnknownError, 
                ex);
        }
    }

    private async Task<T> HandledGetRequest<T>(string path)
    {
        try
        {
            var result = await GetHttpClient().GetFromJsonAsync<T>(path);
            result.ThrowNoResponseIfNull();
            return result!;
        }
        catch (HttpRequestException httpRequestException)
        {
            throw new YouTubeMusicDesktopException(YouTubeMusicDesktopError.RequestError,
                httpRequestException.StatusCode);
        }
    }
    private HttpClient GetHttpClient()
    {
        var httpClient = new HttpClient
        {
            BaseAddress = _options.InstanceUrl
        };
        
        if (_options.Password is not null)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_options.Password}");
        }

        return httpClient;
    }

    [GeneratedRegex(@"=w(\d+)-h(\d+)")]
    private static partial Regex CoverSizeRegex();
}