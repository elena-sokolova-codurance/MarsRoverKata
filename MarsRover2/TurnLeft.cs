namespace MarsRover2;

public class TurnLeft : Command
{
    public TurnLeft(Directions directions) : base(directions)
    {}

    public override void Execute()
    {
        --_directions.CurrentDirection;

        if (_directions.CurrentDirection == -1) {
            _directions.CurrentDirection = 3;
        }
    }
    
}