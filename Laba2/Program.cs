internal class Program
{
    public static void Pause()
    {
        Console.WriteLine("============================");
        Console.Write("Нажмите любую кнопку для продолжения...");
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Validator validator = new Validator();

        int choice = 1;
        while (choice != 0)
        {
            Console.Clear();
            Console.WriteLine("=== Лабораторная работа №1 ===");
            Console.WriteLine(" 0) Выход из программы");

            Console.WriteLine(" 1) 1.1. Точка координат");
            Console.WriteLine(" 2) 2.1. Прямая");
            Console.WriteLine(" 3) 3.1. Студент");
            Console.WriteLine(" 4) 4.1. Создаем точку");
            Console.WriteLine(" 5) 4.7. Создаем студента");
            Console.WriteLine(" 6) 5.6. Студент отличник");

            Console.WriteLine("============================");
            choice = validator.ReadInt("Выберите пункт(0-6): ", 0, 6);
            Console.WriteLine("============================");

            switch (choice)
            {
                case 1:
                    {
                        double x = validator.ReadDouble("Введите координату X первой точки: ");
                        double y = validator.ReadDouble("Введите координату Y первой точки: ");
                        Point point1 = new Point(x, y);
                        x = validator.ReadDouble("Введите координату X второй точки: ");
                        y = validator.ReadDouble("Введите координату Y второй точки: ");
                        Point point2 = new Point(x, y);
                        x = validator.ReadDouble("Введите координату X третьей точки: ");
                        y = validator.ReadDouble("Введите координату Y третьей точки: ");
                        Point point3 = new Point(x, y);
                        Console.WriteLine();

                        Console.WriteLine("Результат:");
                        Console.WriteLine("Точка 1: " + point1);
                        Console.WriteLine("Точка 2: " + point2);
                        Console.WriteLine("Точка 3: " + point3);

                        Pause();
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Третья линия это начало в начале линии 1" +
                            " и конец в конце линни 2:");
                        Point point1 = new Point(1, 3);
                        Point point2 = new Point(23, 8);
                        Line line1 = new Line(point1, point2);
                        Console.WriteLine("Линия 1: " + line1);

                        Point point3 = new Point(5, 10);
                        Point point4 = new Point(25, 10);
                        Line line2 = new Line(point3, point4);
                        Console.WriteLine("Линия 2: " + line2);

                        Line line3 = new Line(point1, point4);
                        Console.WriteLine("Линия 3: " + line3);

                        point1.X = 52; point1.Y = 54;
                        point2.X = 18; point2.Y = 23;
                        point3.X = 3; point3.Y = 4;
                        point4.X = 14; point4.Y = 19;
                        Console.WriteLine("\nПосле изменения координат первой и второй линии:");
                        Console.WriteLine("Линия 1: " + line1);
                        Console.WriteLine("Линия 2: " + line2);
                        Console.WriteLine("Линия 3: " + line3);

                        Console.WriteLine("\nПосле изменения координат первой линии," +
                            " чтобы третья не менялась:");
                        line1.StartPoint = new Point(67, 68);
                        line1.EndPoint = new Point(99, 100);
                        Console.WriteLine("Линия 1: " + line1);
                        Console.WriteLine("Линия 2: " + line2);
                        Console.WriteLine("Линия 3: " + line3);

                        Pause();
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Создание Пети и Васи:");
                        Student student1 = new Student("Вася", [3, 4, 5]);
                        Console.WriteLine(student1);
                        Student student2 = new Student("Петя");
                        Console.WriteLine(student2);

                        Console.WriteLine("\nПосле копирования оценок Васи Пете:");
                        student2.Grades = student1.Grades;
                        Console.WriteLine(student2);

                        Console.WriteLine("\nПосле замены первой оценки Пети на 5:");
                        student2.Grades[0] = 5;
                        Console.WriteLine(student1);
                        Console.WriteLine(student2);

                        Console.WriteLine("\nПосле создания Андрея и копирования ему оценок Васи:");
                        Student student3 = new Student("Андрей");
                        student3.Grades = student1.Grades;
                        Console.WriteLine(student1);
                        Console.WriteLine(student3);

                        Console.WriteLine("\nИзменение оценок Васи не влияет на Андрея:");
                        student1.Grades = [3, 4, 2];
                        Console.WriteLine(student1);
                        Console.WriteLine(student3);

                        Pause();
                        break;
                    }

                case 4:
                    {
                        Point point1 = new Point(3, 5);
                        Point point2 = new Point(25, 6);
                        Point point3 = new Point(7, 8);
                        Console.WriteLine(point1);
                        Console.WriteLine(point2);
                        Console.WriteLine(point3);

                        Pause();
                        break;
                    }

                case 0:
                    Console.WriteLine("Выход из программы.");
                    break;

                default:
                    Console.WriteLine("Ошибка! Введено неверное значение.");
                    Pause();
                    break;
            }





        }
    }
}