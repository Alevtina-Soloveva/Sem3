Console.Clear();
Console.Write("Write your number : ");
string? number = Console.ReadLine();
int count = number.Length - 1;
double newNumber = 0;
for (int i = count; i >=0; i--)
{
    newNumber = newNumber + int.Parse(number[i].ToString()) * Math.Pow(10, i);
}
Console.WriteLine(number == newNumber.ToString());

