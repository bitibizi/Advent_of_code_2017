
void Part1(int input)
{
    
    var startNum = Math.Ceiling(Math.Sqrt(input));
    if (startNum % 2 == 0)
    {
        startNum++;
    }

    var width = startNum - 1;
    var halfRadius=width / 2;
    var bottomRightCornerNumber = Math.Pow(startNum, 2);
    var diff = bottomRightCornerNumber - input;
    var ganger = Math.Floor(diff / width);
    var nearestCorner = bottomRightCornerNumber - width * ganger;
    var middlePoint = nearestCorner - halfRadius;
    var diffMidllePointAndInput = Math.Abs(middlePoint - input);

    var sum = halfRadius + diffMidllePointAndInput;
    
    Console.WriteLine(sum);

}
var input = 347991;
Part1(input);