Console.WriteLine("Please input the number you want to go up to.");
int max = 0;
max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Now factoring the prime numbers from your input");

for (int i = 1; i < max; i++)
{
    if (i%2==1)
    {
        Console.WriteLine(i);
    }
}
Console.ReadKey();
