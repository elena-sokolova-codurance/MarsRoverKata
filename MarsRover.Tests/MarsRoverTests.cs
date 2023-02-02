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
    [InlineData("0:0:E", "RRRRR")]
    [InlineData("0:0:N", "RRRRRRRR")]
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

    [Fact]
    public void RoverGetMultipleCommand()
    {
        var marsRover = new MarsRover2.MarsRover();

        Assert.Equal("1:0:E", marsRover.Execute("RM"));
        
    }
}