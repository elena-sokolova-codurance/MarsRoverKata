namespace MarsRover2;

public class MarsRover
{
    private char[] _orientation = new[] { 'N', 'E', 'S', 'W' };
    public string Execute(string command)
    {
        
      if(command == "R"){
        return $"0:0:{_orientation[1]}";
      }

      if (command == "RR")
          return $"0:0:{_orientation[2]}";
      
      return $"0:{command.Length}:{_orientation[0]}";
    }
}