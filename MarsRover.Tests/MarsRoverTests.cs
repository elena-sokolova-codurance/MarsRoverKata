using MarsRover2;

namespace MarsRover.Tests;

public class MarsRoverTests
{
    [Fact]
    public void InitializeRoverStartPosition()
    {
        var marsRover = new MarsRover2.MarsRover();

        Assert.Equal("0:0:N",  marsRover.Execute(""));
    }

    [Fact]
    public void MoveRoverFrowardOnce()
    {
        var marsRover = new MarsRover2.MarsRover();

        Assert.Equal("0:1:N", marsRover.Execute("M"));
    }
}