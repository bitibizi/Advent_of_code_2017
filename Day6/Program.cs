
void Part1(List<int> input)
{
    
    var lst = new List<List<int>>();
    var stringList = new HashSet<string>();
    var size = input.Count;
    var step = 0;
    lst.Add(input.ToList());
    
    while (true)
    {
        

        if (step != stringList.Count)
        {
            Console.WriteLine(step);
            break;
        }

        var workingOn = lst.Last().ToList();
        var maxNumber = workingOn.Max();
        var firstIndexOfMaxNumber = workingOn
            .Select((number, index) => new { number, index }) // Project into an anonymous type with both number and index
            .Where(item => item.number == maxNumber) // Filter to only the maximum numbers
            .Select(item => item.index) // Select only the indices
            .First();
        workingOn[firstIndexOfMaxNumber] = 0;

        if (size == maxNumber)
        {
            for (var i = 0; i < size; i++)
            {
                workingOn[i] ++ ;
            }
        }else 
        {
            var i = 0;
            while (maxNumber != 0)
            { 
                workingOn[(firstIndexOfMaxNumber + 1 + i)%size]++;
                maxNumber--;
                i++;
            }
        }

        lst.Add(workingOn.ToList());
        stringList.Add(string.Join(",", workingOn.ConvertAll(x => x.ToString())));

        step++;
    }

    

}

var input = new List<int> {2,8,8,5,4,2,3,1,5,5,1,2,15,13,5,14};
Part1(input);