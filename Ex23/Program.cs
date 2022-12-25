Console.Clear();
Console.Write("Write your number : ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < number)
{
    Console.WriteLine(Math.Pow(i, 2));
    i++;
}