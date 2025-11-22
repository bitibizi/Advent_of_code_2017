List<List<String>> GetInput()
{
    const string filePath = "input.txt";
    var fileContents = File.ReadLines(filePath).ToList();
    var input=new List<List<String>>();
    foreach (var line in fileContents)
    {
        var words=line.Split(' ').ToList();
        input.Add(words);
    }
    
    return input;
}

void Part1(List<List<String>> input)
{
    var count = 0;
    foreach (var line in input)
    {
        var lengthList = line.Count;
        var hashset = new HashSet<string>(line); 
        var hashsetSize = hashset.Count;

        if (lengthList == hashsetSize)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

var input=GetInput();
Part1(input);