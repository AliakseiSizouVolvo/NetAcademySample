namespace BasicInterfaces;

public class Cat : IComparable<Cat>
{
    public string Name { get; set; }
    public string Color { get; set; }

    public override int GetHashCode()
    {
        return (Name + Color).GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Cat))
        {
           return this.Name.Equals((obj as Cat).Name);
        }
        else return false;
    }

    public int CompareTo(Cat? other)
    {
        if (ReferenceEquals(this, other)) 
            return 0;
        if (ReferenceEquals(null, other)) 
            return 1;
        var nameComparison = 
            string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) 
            return nameComparison;
        return string.Compare(Color, other.Color, StringComparison.Ordinal);
    }
}

public class CatComparer : IComparer<Cat>
{
    public int Compare(Cat x, Cat y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (ReferenceEquals(null, y)) return 1;
        if (ReferenceEquals(null, x)) return -1;
        var nameComparison = string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;
        return string.Compare(x.Color, y.Color, StringComparison.Ordinal);
    }
}