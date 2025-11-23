List<List<string>> GetInput()
{
    const string filePath = "input.txt";
    var fileContents = File.ReadLines(filePath).ToList();

    return fileContents.Select(line => line.Split(' ').ToList()).ToList();
}

void Part1(List<List<string>> input)
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
    Console.WriteLine("part 1 : " + count);
}

void Part2(List<List<string>> input)
{
    var count = 0;
    foreach (var line in input)
    {
        var lengthList = line.Count;
        var hashset = new HashSet<string>(line); 
        var hashsetSize = hashset.Count;

        if (lengthList == hashsetSize)
        {
            var newHashset = new HashSet<string>();
            foreach (var word in hashset)
            {
                var charArray = word.ToCharArray();
                Array.Sort(charArray);
                var sortedString = new string(charArray);
                newHashset.Add(sortedString);
            }

            if (newHashset.Count == hashset.Count)
            {
                count++;
            }
        }
    }
    Console.WriteLine("part 2 " + count);
}
var input=GetInput();
Part1(input);
Part2(input);