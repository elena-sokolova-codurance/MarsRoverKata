namespace MarsRover2;

public class MarsRover
{
    private char[] _orientation = new[] { 'N', 'E', 'S', 'W' };
    public string Execute(string command)
    {
        int turn = 0;
        var y = 0;
        foreach (var singleCommand in command)
        {
            if (singleCommand == 'R')
              turn = Command.TurnRight(turn);
            if (singleCommand == 'M')
              y = Command.Move(y);
        }

        return $"0:{y}:{_orientation[turn]}";
    }
}