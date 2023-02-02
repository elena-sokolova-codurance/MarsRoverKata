namespace MarsRover2;

public abstract class Command
{
    protected Directions _directions;

    public Command(Directions directions)
    {
        _directions = directions;
    }

    public abstract void Execute();
    
    
    public static int Move(int y)
    {
        return ++y;
    }
}