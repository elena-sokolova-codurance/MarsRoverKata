namespace MarsRover2;

public class TurnRight : Command
{
    public TurnRight(Directions directions) : base(directions)
    {}
    
    public override void Execute()
    {
        ++_directions.CurrentDirection;

        if (_directions.CurrentDirection == 4)
            _directions.CurrentDirection = 0;
    }
}