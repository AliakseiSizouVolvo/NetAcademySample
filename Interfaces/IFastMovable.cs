namespace Interfaces;

public interface IFastMovable : IMovable
{
    public void MoveFast();
}

public interface ISlowMovable : IMovable
{
    public void MoveSlow();
}

public interface IAdaptiveMovable : IFastMovable, ISlowMovable
{

}

