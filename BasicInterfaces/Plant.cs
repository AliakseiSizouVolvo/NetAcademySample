using System.Collections;

namespace BasicInterfaces;

public class Plant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type{ get; set; }
    public string State{ get; set; }
}

public class Farm : IEnumerable<Plant>
{
    //private Dictionary<int, Plant> _gardenPlants;

    private List<Plant> _list;

    public Farm(List<Plant> list)//(Dictionary<int, Plant> gardenPlants)
    {
        _list = list;
        //_gardenPlants = gardenPlants;
    }

    public IEnumerator<Plant> GetEnumerator()
    {
        return _list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}