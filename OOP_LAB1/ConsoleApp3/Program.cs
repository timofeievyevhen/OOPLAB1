using System;

namespace ConsoleApp3
{
    internal class Program
    {

        static string chooseSide()
        {
            Console.Write("Оберіть сторону A, B або C: ");
            string side = Console.ReadLine();
            return side;

        }
        static void Main(string[] args)
        {
            bool startProg = true;

            while (startProg)
            {
                Console.WriteLine();
                Console.WriteLine("1 - TTriangle");
                Console.WriteLine("2 - Matrix");
                Console.WriteLine("3 - TETriangle");
                Console.WriteLine("4 - TEPiramid");
                Console.WriteLine("0 - Вихід");
                Console.Write("Виберіть номер завдання: ");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Write("Введіть сторони A, B, C через пробіл:");
                        string[] data = Console.ReadLine().Split();
                        TTriangle triangle = new TTriangle(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]));

                        bool task1 = true;
                        while (task1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - Отримати довжину сторони");
                            Console.WriteLine("2 - Задати довжину однієї сторони");
                            Console.WriteLine("3 - Отримати периметр трикутника");
                            Console.WriteLine("4 - Отримати площі трикутника");
                            Console.WriteLine("0 - Вихід");
                            Console.Write("Виберіть номер: ");

                            int input2 = int.Parse(Console.ReadLine());
                            switch (input2)
                            {
                                case 1:
                                    string side = chooseSide();
                                    if (side == "A" || side == "a")
                                    {
                                        Console.WriteLine($"Сторона А: {triangle.getA()}");
                                    }
                                    else if(side == "B" || side == "b")
                                    {
                                        Console.WriteLine($"Сторона B: {triangle.getB()}");
                                    }
                                    else if (side == "C" || side == "c")
                                    {
                                        Console.WriteLine($"Сторона C: {triangle.getC()}");
                                    }
                                    break;
                                case 2:
                                    string side2 = chooseSide();
                                    Console.WriteLine("Змінити на: ");
                                    int newSide = int.Parse(Console.ReadLine());
                                    if (side2 == "A" || side2 == "a")
                                    {
                                        triangle.setA(newSide);
                                    }
                                    else if (side2 == "B" || side2 == "b")
                                    {
                                        triangle.setB(newSide);
                                    }
                                    else if (side2 == "C" || side2 == "c")
                                    {
                                        triangle.setC(newSide);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine($"Периметр: {triangle.getPerimeter()}");
                                    break;
                                case 4:
                                    Console.WriteLine($"Площа: {triangle.getArea()}");
                                    break;
                                case 0:
                                    task1 = false;
                                    break;
                                default:
                                    Console.WriteLine("Некоректний вибір");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.Write("Введіть розмірність матриці a та b через пробіл:");
                        string[] matrixSize = Console.ReadLine().Split();
                        Matrix matrix = new Matrix(int.Parse(matrixSize[0]), int.Parse(matrixSize[1]));
                        matrix.input();
                        bool task2 = true;
                        while (task2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - Вивести матрицю");
                            Console.WriteLine("2 - Задати один елемент матриці");
                            Console.WriteLine("3 - Знайти найменше");
                            Console.WriteLine("4 - Знайти найбільше");
                            Console.WriteLine("0 - - Вихід");
                            Console.Write("Виберіть номер: ");

                            int input2 = int.Parse(Console.ReadLine());
                            switch (input2)
                            {
                                case 1:
                                    matrix.print();
                                    break;
                                case 2:
                                    Console.WriteLine("Введіть індекс елемента, який бажаєте замінити");
                                    string[] idx = Console.ReadLine().Split();
                                    Console.WriteLine("Введіть значення нового елементу");
                                    int num = int.Parse(Console.ReadLine());
                                    matrix[int.Parse(idx[0]), int.Parse(idx[1])] = num;
                                    break;
                                case 3:
                                    Console.WriteLine($"Мінімальний елемент: {matrix.getMin()}");
                                    break;
                                case 4:
                                    Console.WriteLine($"Максимальный элемент: {matrix.getMax()}");
                                    break;
                                case 0:
                                    task2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Некоректний вибір");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Введіть значення сторони:");
                        int size1 = int.Parse(Console.ReadLine());
                        TETriangle t1 = new TETriangle(size1);
                        bool task3 = true;
                        while (task3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - Вивести довжину сторони");
                            Console.WriteLine("2 - Ввести довжину сторони");
                            Console.WriteLine("3 - Знайти полоща");
                            Console.WriteLine("4 - Знайти периметр");
                            Console.WriteLine("5 - Порівняти з іншим трикутником");
                            Console.WriteLine("6 - Множення");
                            Console.WriteLine("0 - Вихід");
                            Console.Write("Виберіть номер: ");

                            int input2 = int.Parse(Console.ReadLine());
                            switch (input2)
                            {
                                case 1:
                                    t1.print();
                                    break;
                                case 2:
                                    t1.input();
                                    break;
                                case 3:
                                    Console.WriteLine($"Площа: {t1.getArea()}");
                                    break;
                                case 4:
                                    Console.WriteLine($"Периметр: {t1.getPerimeter()}");
                                    break;
                                case 5:
                                    Console.WriteLine("Введіть значення сторони другого трикутника:");
                                    int size2 = int.Parse(Console.ReadLine());
                                    TETriangle t2 = new TETriangle(size2);
                                    if(t1.comparison(t1, t2))
                                    {
                                        Console.WriteLine("Трикутники рівні");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Трикутники не рівні");
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("Введіть число на яке помножити трикутник");
                                    int num = int.Parse(Console.ReadLine());
                                    TETriangle t3 = t1 * num;
                                    t3.print();
                                    break;
                                case 0:
                                    task3 = false;
                                    break;
                                default:
                                    Console.WriteLine("Некоректний вибір");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.Write("Введіть значення сторони:");
                        int size3 = int.Parse(Console.ReadLine());
                        Console.Write("Введіть значення висоти:");
                        int height = int.Parse(Console.ReadLine());
                        TEPiramid p1 = new TEPiramid(size3, height);
                        bool task4 = true;
                        while (task4)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - Вивести довжину сторони та висоту");
                            Console.WriteLine("2 - Ввести довжину сторони та висоту");
                            Console.WriteLine("3 - Знайти полощу");
                            Console.WriteLine("4 - Знайти периметр");
                            Console.WriteLine("5 - Знайти об’єм");
                            Console.WriteLine("6 - Порівняти з іншою пірамідою");
                            Console.WriteLine("7 - Множення");
                            Console.WriteLine("0 - Вихід");
                            Console.Write("Виберіть номер: ");

                            int input2 = int.Parse(Console.ReadLine());
                            switch (input2)
                            {
                                case 1:
                                    p1.print();
                                    break;
                                case 2:
                                    p1.input();
                                    break;
                                case 3:
                                    Console.WriteLine($"Площа: {p1.getArea()}");
                                    break;
                                case 4:
                                    Console.WriteLine($"Периметр: {p1.getPerimeter()}");
                                    break;
                                case 5:
                                    Console.WriteLine($"Об’єм: {p1.getVolume()}");
                                    break;
                                case 6:
                                    Console.Write("Введіть значення сторони другої піраміди: ");
                                    int size4 = int.Parse(Console.ReadLine());
                                    Console.Write("Введіть значення висоти другої піраміди: ");
                                    int height2 = int.Parse(Console.ReadLine());
                                    TEPiramid p2 = new TEPiramid(size4, height2);
                                    if (p1.comparison(p1, p2))
                                    {
                                        Console.WriteLine("Піраміди рівні");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Піраміди не рівні");
                                    }
                                    break;
                                case 7:
                                    Console.WriteLine("Введіть число на яке помножити піраміду");
                                    int num = int.Parse(Console.ReadLine());
                                    TETriangle t3 = p1 * num;
                                    t3.print();
                                    break;
                                case 0:
                                    task4 = false;
                                    break;
                                default:
                                    Console.WriteLine("Некоректний вибір");
                                    break;
                            }
                        }
                        break;
                    case 0:
                        startProg = false;
                        Console.WriteLine("Завершення роботи програми");
                        break;
                    default:
                        Console.WriteLine("Некоректний вибір. Спробуйте ще раз");
                        break;
                }
            }
        }
    }
}
