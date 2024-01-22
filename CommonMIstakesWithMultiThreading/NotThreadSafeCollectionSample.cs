using System.Collections.Concurrent;

namespace CommonMistakesWithMultiThreading;

public class NotThreadSafeCollectionSample
{
    private readonly IDictionary<int, Model> _dictionary
        = new Dictionary<int, Model>();

    private readonly IDictionary<int, Model> _concurrentDictionary
        = new ConcurrentDictionary<int, Model>();

    private readonly ConcurrentBag<Model> _concurrentBag 
        = new ConcurrentBag<Model>();
    private readonly object _lock = new object();

    public Model GetData(int id)
    {
        //lock (_lock)
        //{
            return _concurrentDictionary
                .TryGetValue(id, out var data)
                ? data
                : null;
        //}
    }

    public void AddData(Model model)
    {
        //lock (_lock)
        //{
        _concurrentBag.Add(model);
        
        _concurrentDictionary.TryAdd(model.Id, model);
        var cd = new ConcurrentDictionary<int, Model>(_dictionary);
        //}
    }

    public void RemoveData(int id)
    {
        //lock (_lock)
        //{
            _concurrentDictionary.Remove(id);
        //}
    }
}

public class Model
{
    public int Id { get; set; }
}