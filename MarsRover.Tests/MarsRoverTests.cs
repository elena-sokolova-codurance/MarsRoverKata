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
    public void MoveRoverForwardOnce()
    {
        var marsRover = new MarsRover2.MarsRover();

        Assert.Equal("0:1:N", marsRover.Execute("M"));
    }

    [Fact]
    public void MoveRoverForwardTwice()
    {
        var marsRover = new MarsRover2.MarsRover();

        Assert.Equal("0:2:N", marsRover.Execute("MM"));
    }

    [Fact]
    public void RotateRoverToRightOnce()
    {
        var marsRover = new MarsRover2.MarsRover();

        Assert.Equal("0:0:E", marsRover.Execute("R"));
    }
}