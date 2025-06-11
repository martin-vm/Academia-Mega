using System.Collections.Concurrent;
using GrpcChat;

namespace ChatServer.Services;

/// <summary>
/// Gestiona las conexiones y reenvía los mensajes
/// </summary>

public class ChatHub
{
    private readonly ConcurrentDictionary<string, IServerStreamWriter<ChatMessage>>
        _streams = new();

    public void Join(string user, IServerStreamWriter<ChatMessage> stream)
        => _stream[user] = stream;

    public void Leave(string user)
        => _streams.TryRemove(user, out _);

    public async Task BroadcastAsync(ChatMessage msg, CancellationToken ct)
    {
        foreach (var item in _streams)
        {
            if (ct.IsCancellationRequest) break;
            await item.Value.WriteAsync(msg);
        }
    }
}