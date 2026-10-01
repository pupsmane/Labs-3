// Найдите и выведите все двузначные числа, которые равны удвоенному произведению своих цифр.

for(int i =10; i<100; i++)
{
   int a = i / 10;
   int b = i % 10;
   if (i == 2 * a * b)
    {
        Console.WriteLine($"{i}");
    }
}

int i = 10;
while(i<100)
{
    i++;
    int a = i / 10;
    int b = i % 10;
    if (i == 2 * a * b)
    {
        Console.WriteLine($"{i}");
    }
}
