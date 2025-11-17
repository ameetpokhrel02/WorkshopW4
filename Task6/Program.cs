//get user input
Console.WriteLine("Enter marks:");
int marks = int.Parse(Console.ReadLine());

Console.WriteLine("Enter total:");
int total = int.Parse(Console.ReadLine());

//lets calculate percentage
double percentage = (double)marks / total * 100;

//Display result
Console.WriteLine($"Percentage: {percentage}%");