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
    
    [Theory]
    [InlineData("0:1:N", "M")]
    [InlineData("0:2:N", "MM")]
    public void MoveRoverForward(string expectedResult, string command)
    {
        var marsRover = new MarsRover2.MarsRover();
        Assert.Equal(expectedResult, marsRover.Execute(command));
    }

    [Theory]
    [InlineData("0:0:E", "R")]
    [InlineData("0:0:S", "RR")]
    [InlineData("0:0:W", "RRR")]
    [InlineData("0:0:N", "RRRR")]
    public void RotateRoverToRight(string expectedResult, string command)
    {
        var marsRover = new MarsRover2.MarsRover();

        Assert.Equal(expectedResult, marsRover.Execute(command));
    }

    [Fact]
    public void Test()
    {
        var marsRover = new MarsRover2.MarsRover();
        Assert.Equal("0:0:E", marsRover.Execute("R"));
        Assert.Equal("0:0:S", marsRover.Execute("R"));
    }

    [Theory]
    [InlineData("0:0:W", "L")]
    [InlineData("0:0:S", "LL")]
    [InlineData("0:0:E", "LLL")]
    [InlineData("0:0:N", "LLLL")]
    public void RotateRoverToLeft(string expectedResult, string command)
    {
        var marsRover = new MarsRover2.MarsRover();

        Assert.Equal(expectedResult, marsRover.Execute(command));
    }
}