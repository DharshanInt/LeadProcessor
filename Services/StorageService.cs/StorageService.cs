using System.Collections.Generic;

public class InMemoryStorageService : IStorageService
{
    private readonly Dictionary<string, List<Lead>> _storage = new Dictionary<string, List<Lead>>
    {
        { "facebook", new List<Lead>() },
        { "LinkedIn", new List<Lead>() },
        { "instagram", new List<Lead>() }
    };

    public void StoreLead(Lead lead)
    {
        if (!_storage.ContainsKey(lead.Source.ToLower()))
        {
            throw new ArgumentException($"Unsupported lead source: {lead.Source}");
        }

        _storage[lead.Source.ToLower()].Add(lead);
    }

    public List<Lead> GetLeadsBySource(string source)
    {
        if (!_storage.ContainsKey(source.ToLower()))
        {
            throw new ArgumentException($"Unsupported lead source: {source}");
        }

        return _storage[source.ToLower()];
    }
}
