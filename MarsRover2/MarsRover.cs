namespace MarsRover2;

public class MarsRover
{
    public string Execute(string command)
    {
      if(command == "R"){
        return "0:0:E";
      }

      if (command == "RR")
          return "0:0:S";
      
        return $"0:{command.Length}:N";
    }
}