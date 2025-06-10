using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
public class FakeSession : ISession
{
    private readonly Dictionary<string, byte[]> _store = new();

    public IEnumerable<string> Keys => _store.Keys;

    public bool IsAvailable => true;

    public string Id => "FakeSessionId";
    public void Clear()
        => _store.Clear();

    public Task CommitAsync(CancellationToken cancellationToken = default)
        => Task.CompletedTask;

    public Task LoadAsync(CancellationToken cancellationToken = default)
        => Task.CompletedTask;

    public void Remove(String key)
        => _store.Remove(key);

    public void Set(String key, byte[] value)
        => _store[key] = value;

    public void TryGetValue(String key, out byte[] value)
        => _store.TryGetValue(key, out value);

    bool ISession.TryGetValue(string key, out byte[]? value)
    {
        throw new NotImplementedException();
    }
}