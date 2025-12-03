List<string> GetInput()
{
    const string filePath = "input.txt";
    var fileContents = File.ReadLines(filePath).ToList();
    return fileContents;
}

string Part1(List<string> input)
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
        var result = numbers.FirstOrDefault(x => x.Value == 1).Key;
        Console.WriteLine(result);
        return result;
    }

    return "Not Found";
}



void Part2(List<string> input, string root)
{
    var rootProgram = input.First(x => x.StartsWith(root)).Split(' ');
    
    var children = rootProgram[3..].Select(c => c.TrimEnd(','));
    var dict = new Dictionary<string, int>();
    foreach (var child in children) 
    {
        var childWeight = GetTotalWeight(input, child);
        dict.Add(child, childWeight);
    }
    
    var diffWeightChild = dict.Values.All(val => val.Equals(dict.Values.FirstOrDefault()));
    
    if (!diffWeightChild)
    {
        Console.WriteLine(string.Join(", ", dict.Select(pair => pair.Key + ": " + pair.Value)));
        var oddChild = dict.
            GroupBy(x => x.Value)
            .Where(g => g.Count() == 1)
            .Select(g => g.First().Key).First();
        
        Part2(input, oddChild);
    }
    else
    {
        Console.WriteLine("The wrong weight is written above ☝️");
    }

}

int GetTotalWeight(List<string> input, string root)
{
    var rootProgram = input.First(x => x.StartsWith(root)).Split(' ');
    var weight = int.Parse(rootProgram[1].Trim('(', ')'));
    if (rootProgram.Length < 3)
    {
        return weight;
    }

    var children = rootProgram[3..].Select(c => c.TrimEnd(','));
    
    foreach (var child in children)
    {
        weight += GetTotalWeight(input, child);
    }
    
    return weight;
}

var input = GetInput();
var root=Part1(input);
Part2(input, root);
