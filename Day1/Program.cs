
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

Console.WriteLine(sum);