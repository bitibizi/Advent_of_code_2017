List<int> GetInput()
{
    const string filePath = "input.txt";
    var fileContents = File.ReadLines(filePath).Select(int.Parse).ToList();
    return fileContents;
}

void Part1(List<int> input)
{
    var position = 0;
    var step = 0;
 
    while (position < input.Count)
    { 
        var oldValue = input[position]; 
        input[position] ++; 
        position += oldValue;
        step++;

    }
    
    Console.WriteLine("The part 1 is " + step);

}

void Part2(List<int> input)
{
    var position = 0;
    var step = 0;
 
    while (position < input.Count)
    { 
        var oldValue = input[position];
        if (oldValue >= 3)
        {
            input[position] --;
        }
        else
        {
            input[position] ++;
        }
        position += oldValue;
        step++;

    }
    
    Console.WriteLine("the part 2 is " + step);
}

var input1 = GetInput();
var input2 = GetInput();
Part1(input1);
Part2(input2);