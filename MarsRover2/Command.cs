namespace MarsRover2;

public class Command
{

    public static int TurnRight(int turn)
    {
        return ++turn;
    }
    public static int TurnLeft(int turn)
    {
        int result =  --turn;

        if (result == -1) {
            return 3;
        }
        return result;
    }
    public static int Move(int y)
    {
        return ++y;
    }
}