using MarsRover2;

namespace MarsRover.Tests;

public class MarsRoverTests
{
    [Fact]
    public void InitializeRoverStartPosition()
    {
        var marsRover = new MarsRover2.MarsRover();
        var startPosition = marsRover.Initialize();
        
        Assert.Equal("0:0:N", startPosition);
    }
}