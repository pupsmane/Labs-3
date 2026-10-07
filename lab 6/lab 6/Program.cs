/* Дана последовательность целых чисел, содержащих два нуля. Вывести все элементы между нулями. 

 using System;

class Program
{
    static void Main()
    {  
        int[] nums = { 0, 3, 3, 7, 8, 0, 2, 0 };

        int zero1 = -1;
        int zero2 = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                if (zero1 == -1)
                    zero1 = i;
                else
                {
                    zero2 = i;
                    break; 
                }
            }
        }

        if (zero1 == -1 || zero2 == -1)
        {
            Console.WriteLine("В последовательности нет двух нулей.");
            return;
        }

        Console.WriteLine("Элементы между нулями:");
        for (int i = zero1 + 1; i < zero2; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}
*/

//В матрице m x n заменить все нули максимальным элементом.

Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int [m,n];

for(int i =0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.WriteLine($"Введите {i + 1},{j + 1} элементы");
        nums[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

int max = nums[0, 0];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (nums[i,j] > max)
        {
            max = nums[i,j];
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (nums[i, j] == 0)
        {
            nums[i, j] = max;
        }
    }
}

    Console.WriteLine($"Максимум: {max}");
    Console.WriteLine("Результат:");
    
    for (int i = 0; i <m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write(nums[i, j]);
        Console.WriteLine();
    }


