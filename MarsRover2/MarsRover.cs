namespace MarsRover2;

public class MarsRover
{
    public string Execute(string command)
    {
        if(command == "M"){
          return "0:1:N";
        }
        return "0:0:N";

    }
}