List<string> GetInput()
{
    const string filePath = "input.txt";
    var fileContents = File.ReadLines(filePath).ToList();
    return fileContents;
}

void Part1(List<string> input)
{
    var dict = new Dictionary<string, int>();
    var operators = new Dictionary<string, Func<int, int, bool>>()
    {
        { ">",  (reg, val) => reg > val },
        { "<",  (reg, val) => reg < val },
        { ">=", (reg, val) => reg >= val },
        { "<=", (reg, val) => reg <= val },
        { "==", (reg, val) => reg == val },
        { "!=", (reg, val) => reg != val }
    };

    foreach (var line in input)
    {
        var parts = line.Split(' ');
        var firstKey = parts[0];
        var secondKey = parts[4];
        var numToAdd = int.Parse(parts[2]);
        var numToCompare = int.Parse(parts[6]);
        var comm = parts[1];
        var ope = parts[5];
        
        dict.TryAdd(firstKey, 0); 
        dict.TryAdd(secondKey, 0);

        if (!operators[ope](dict[secondKey], numToCompare)) continue;
        if (comm == "inc")
        {
            dict[firstKey] += numToAdd;
        }
        else
        {
            dict[firstKey] -= numToAdd;
        }
    }
    
    var max = dict.Values.Max();
    Console.WriteLine(max);
}


var input = GetInput();
Part1(input);
