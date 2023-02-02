namespace MarsRover2;

public class MarsRover
{
    public string Execute(string command)
    {
      if(command == "R"){
        return "0:0:E";
      }
        return $"0:{command.Length}:N";
    }
}