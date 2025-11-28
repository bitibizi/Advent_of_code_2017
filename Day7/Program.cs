List<string> GetInput()
{
    const string filePath = "input.txt";
    var fileContents = File.ReadLines(filePath).ToList();
    return fileContents;
}

void Part1(List<string> input)
{
    var numbers = new Dictionary<string, int>();
    
    foreach (var i in input)
    {
        var word = i.Split(' ')[0];
        
        numbers.Add(word, 0);
        
        foreach (var j in input)
        {
            if (!j.Contains(word)) continue;
            numbers[word]++;
            
        }
    }

    if (numbers.ContainsValue(1))
    {
        var result = numbers.FirstOrDefault(x => x.Value == 1);
        Console.WriteLine(result);
    }
}

var input = GetInput();
Part1(input);
