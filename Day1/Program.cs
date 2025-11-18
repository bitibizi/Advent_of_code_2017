
const string filePath = "input.txt";
var fileContents = File.ReadAllText(filePath);
Console.WriteLine("File contents:\n" + fileContents);

var sum=0;

for (var i = 0; i < fileContents.Length; i++)
{
    var number = fileContents[i];
    var secondNumber = fileContents[(i+1)%fileContents.Length];
    
    if (number == secondNumber)
    {
        sum += int.Parse(number.ToString());
    }
}

Console.WriteLine("star 1 : "+ sum);

sum=0;
var halfLength = fileContents.Length / 2;

for (var i = 0; i < fileContents.Length; i++)
{
    
    var number = fileContents[i];
    var secondNumber = fileContents[(i+halfLength)%fileContents.Length];
    
    if (number == secondNumber)
    {
        sum += int.Parse(number.ToString());
    }
}

Console.WriteLine("star 2 : "+ sum);