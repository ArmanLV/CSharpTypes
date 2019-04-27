// Подключение статической директивы, чтобы постоянно не прописывать путь
// Console.WriteLIne(...); => WriteLine(...);
using static System.Console;

namespace CSharp7
{
    // Основной класс
    class Program
    {
        public struct Point1 { public int x; public int y; }

        static void Main()
        {
            // Разница между типом значений и ссылочным типом

            // Point1 - Тип значений (struct)
            // Point - Ссылочный тип (class)

            Point1 p1 = new Point1();
            p1.x = 25;

            // Присвоение экземпляра типа значений
            // Приводит к копированию этого экземпляра
            Point1 p2 = p1;

            p1.x = 700;

            // Так как мы реализовали всё через структуру
            // то у каждого параметра хранится своё значение
            WriteLine(p1.x); // 700
            WriteLine(p2.x); // 25

            // \n - перенос строки
            WriteLine("\n---\n");

            Point p3 = new Point();            
            p3.x = 145;

            // Присвоение ссылочного типа вызывает не копирование экземпляра
            // А копирование ссылки, таким образом можно множеству переменных
            // Ссылаться на один и тот же объект
            Point p4 = p3;
            p3.x = 444;

            WriteLine(p3.x); // 444
            WriteLine(p4.x); // 444

            ReadLine();
        }
    }

    // Класс для примера
    public class Point
    {
        public int x, y;
    }

}
