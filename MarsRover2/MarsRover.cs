namespace MarsRover2;

public class MarsRover
{
    public string Execute(string command)
    {
        var y = 0;

        foreach (var singleCommand in command)
        {
            if (singleCommand.Equals('M'))
                y++;
        }

        return $"0:{y}:N";
    }
}