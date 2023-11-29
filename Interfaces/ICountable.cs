namespace Interfaces;

public interface ICountable
{
    public void Count();
}


public interface IMovableAndCountable : IMovable, ICountable
{

}