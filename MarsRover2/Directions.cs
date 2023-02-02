namespace MarsRover2;

public class Directions
{
    private readonly char North = 'N';
    private readonly char East = 'E';
    private readonly char South = 'S';
    private readonly char West = 'W';
    
    private char[] _orientation = new[] { 'N', 'E', 'S', 'W' };
    
    public int CurrentDirection = 0;

    public char GetDirection()
    {
        return _orientation[CurrentDirection];
    }
    
    
}