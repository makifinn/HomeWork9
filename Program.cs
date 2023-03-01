bool IsWork = true;

while (IsWork)

{
    Console.WriteLine();
    Console.WriteLine("Выберите программу:");
    Console.WriteLine("1 - Программа выводит все натуральные числа в промежутке от N до 1");
    Console.WriteLine("2 - Программа находит сумму натуральных элементов от M до N");
    Console.WriteLine("3 - Программа вычисляет функцию Аккермана");
    Console.WriteLine("-1 - Для завершения работы");
    Console.Write("Выберите программу: ");

    int ReadInt(string argument)
    {
        Console.Write($"{argument}");
        int number;

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("вы ввели не число");
        }

        return number;
    }

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
                {
                    Task_1();

                    void Task_1()
                    {
                        int number = ReadInt("Введите число: ");
                        Console.WriteLine(GetNumbers(number));

                        string GetNumbers(int number)
                        {
                            if (number > 0)
                            {
                                if (number > 1) return $"{number} " + GetNumbers(number - 1);
                                else return $"{number}";
                            }
                            else return $"введите натуральное число";
                        }
                    }

                    break;
                }
            case 2:
                {
                    Task_2();

                    void Task_2()
                    {
                        int m = ReadInt("Введите число M: ");
                        int n = ReadInt("Введите число N: ");
                        Console.WriteLine(GetSumBetweanPoints(m, n));

                        int GetSumBetweanPoints(int m, int n)
                        {
                            if (m < 1 && n < 1)
                            {
                                return 0;
                            }
                            else
                            {
                                if (n > 0)
                                {
                                    if (m > 0)
                                    {
                                        if (m == n) return m;
                                        else return m + GetSumBetweanPoints(m + 1, n);
                                    }
                                    else
                                    {
                                        while (m < 1)
                                        {
                                            m += 1;
                                        }
                                        if (m == n) return m;
                                        else return m + GetSumBetweanPoints(m + 1, n);
                                    }
                                }
                                else
                                {
                                    while (n < 0)
                                    {
                                        n += 1;
                                    }
                                    if (m == n) return m;
                                    else return m + GetSumBetweanPoints(m - 1, n);
                                }
                            }
                        }
                    }

                    break;
                }
            case 3:
                {
                    Task_3();

                    void Task_3()
                    {
                        int m = ReadInt("Введите число m: ");
                        int n = ReadInt("Введите число n: ");

                        Console.WriteLine(AckermannFunction(m, n));

                        int AckermannFunction(int m, int n)
                        {
                            if (n >= 0 && m >= 0)
                            {
                                if (m == 0)
                                {
                                    return n + 1;
                                }
                                else if (n == 0)
                                {
                                    return AckermannFunction(m - 1, 1);
                                }
                                else
                                {
                                    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
                                }
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    }

                    break;
                }

            case -1: IsWork = false; break;
        }
    }
}