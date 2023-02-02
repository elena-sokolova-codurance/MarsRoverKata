namespace MarsRover2;

public class MarsRover
{
    private Directions _directions = new();

    public string Execute(string commands)
    {
        var y = 0;
        foreach (var singleCommand in commands)
        {
            if (singleCommand == 'R')
            {
                Command command = new TurnRight(_directions);
                command.Execute();
            }

            if (singleCommand == 'L')
            {
                Command command = new TurnLeft(_directions);
                command.Execute();
            }
            if (singleCommand == 'M')
                y = Command.Move(y);
        }

        return $"0:{y}:{_directions.GetDirection()}";
    }
}