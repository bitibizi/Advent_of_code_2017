
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

int Part2(int input)
{
    const int matrixSize = 100;
    var matrix = new int[matrixSize, matrixSize];

    var x = matrixSize / 2;
    var y = x;
    matrix[y, x] = 1;
    var step = 1;
    
    while (true)
    {
        int result;
        for (var i = 0; i < step; i++)
        {
            x++;
            result = 0;
            result += matrix[y, x - 1];
            result += matrix[y - 1, x - 1];
            result += matrix[y - 1, x];
            result += matrix[y - 1, x + 1];
            matrix[y, x] = result;
            
            if (input < result)
            { 
                return result;
            }
        }
        for (var i = 0; i < step; i++)
        {
            y--;
            result = 0;
            result += matrix[y + 1, x];
            result += matrix[y + 1, x - 1];
            result += matrix[y , x - 1];
            result += matrix[y - 1, x - 1];
            matrix[y, x] = result;
            if (input < result)
            { 
                return result;
            }
        }

        step++;
        for (var i = 0; i < step; i++)
        {
            x--;
            result = 0;
            result += matrix[y, x + 1];
            result += matrix[y + 1, x + 1];
            result += matrix[y + 1, x];
            result += matrix[y + 1, x - 1];
            matrix[y, x] = result;
            if (input < result)
            { 
                return result;
            }
        }
        for (var i = 0; i < step; i++)
        {
            y++;
            result = 0;
            result += matrix[y - 1, x];
            result += matrix[y - 1, x + 1];
            result += matrix[y, x + 1];
            result += matrix[y + 1, x + 1];
            matrix[y, x] = result;
            if (input < result)
            { 
                return result;
            }
        }

        step++;
    }
    
    
}

const int input = 347991;
Part1(input);
var result=Part2(input);
Console.WriteLine("the part2 answer is "+ result);
