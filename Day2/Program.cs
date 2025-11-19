List<List<int>> GetInput()
{
    const string filePath = "input.txt";
    var fileContents = File.ReadLines(filePath).ToList();
    var input=new List<List<int>>();
    foreach (var line in fileContents)
    {
        var numbers=line.Split('\t').Select(int.Parse).ToList();
        input.Add(numbers);
    }
    
    return input;
}


void SolvePart1(List<List<int>> input)
{
    var sum = 0;
    foreach (var number in input)
    {
        var max = number.Max();
        var min = number.Min();
        var diff=max-min;
        sum += diff;
        
    }
    Console.Write("Part1 sum is "+sum);

}

var input=GetInput();
SolvePart1(input);
