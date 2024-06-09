namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplxNum num1 = new ComplxNum(3, 2);
            ComplxNum num2 = new ComplxNum(3, 7);
            string filePath = "ComplxNum.txt";
            Console.WriteLine("Number 1: " + num1);
            Console.WriteLine("Number 2: " + num2);
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);

            ComplxNum sum = num1 + num2;
            ComplxNum subtr = num1 - num2;
            ComplxNum mult = num1 * num2;
            ComplxNum div = num1 / num2;
            ComplxNum.SaveToFile(filePath, "Num1: " + num1);
            ComplxNum.SaveToFile(filePath, "Num2:  " + num2);
            ComplxNum.SaveToFile(filePath, "Addition: " + sum);
            ComplxNum.SaveToFile(filePath, "Subtraction:  " + subtr);
            ComplxNum.SaveToFile(filePath, "Multiplication:  " + mult);
            ComplxNum.SaveToFile(filePath, "Division:  " + div);

            num1.IsEqual(num2);
            num1.IsCnjugate(num2);
            num1.IsOpposite(num2);
        }
    }
}
