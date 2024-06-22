using LabWorkLibrary;
namespace LabWork23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5 + 3 = {Maths.GetSum(5, 3)}");
            Console.WriteLine($"10 - 2 = {Maths.GetDifference(10, 2)}");
            Console.WriteLine($"4 * 6 = {Maths.GetMultiply(4, 6)}");
            Console.WriteLine($"20 / 5 = {Maths.GetDivide(20, 5)}");
            Console.WriteLine($"Площадь прямоугольника со сторонами 4 и 9 = {Maths.GetRectangleArea(4, 9)}");
            Console.WriteLine($"Константа BINARY_FACTOR = {Maths.BINARY_FACTOR}");
        }
    }
}
