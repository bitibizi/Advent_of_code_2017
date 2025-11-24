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
    
    Console.WriteLine(step);

}

var input = GetInput();
Part1(input);