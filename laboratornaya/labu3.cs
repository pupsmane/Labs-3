Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
int S = 0;

for (int i=3; i <= x; i+=2)
{
  S = S+i;
}
Console.WriteLine($"Сумма S = {S}");