
namespace ConsoleApp44
{
    public class ComplxNum
    {
        public double a { get; set; }
        public double b { get; set; }
        public ComplxNum(double firstn, double secondn)
        {
            a = firstn;
            b = secondn;
        }
        public static ComplxNum operator +(ComplxNum c1, ComplxNum c2)
        {
            return new ComplxNum(c1.a + c2.a, c1.b + c2.b);
        }
        public static ComplxNum operator -(ComplxNum c1, ComplxNum c2)
        {
            return new ComplxNum(c1.a - c2.a, c1.b - c2.b);
        }
        public static ComplxNum operator *(ComplxNum c1, ComplxNum c2)
        {
            double real = c1.a * c2.a - c1.b * c2.b;
            double imaginary = c1.a * c2.b + c1.b * c2.a;
            return new ComplxNum(real, imaginary);
        }
        public static ComplxNum operator /(ComplxNum c1, ComplxNum c2)
        {
            double denominator = c2.a * c2.a + c2.b * c2.b;
            double real = (c1.a * c2.a + c1.b * c2.b) / denominator;
            double imaginary = (c1.b * c2.a - c1.a * c2.b) / denominator;
            return new ComplxNum(real, imaginary);
        }
        public override string ToString()
        {
            return $"{a} + {b}i";
        }
        public static void SaveToFile(string filePath, string text)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(text);
            }
        }
        public bool IsEqual(ComplxNum num)
        {
            return a == num.a && b == num.b;
        }
        public bool IsCnjugate(ComplxNum num)
        {
            return a == num.a && b == -num.b;
        }
        public bool IsOpposite(ComplxNum num)
        {
            return a == -num.a && b == -num.b;
        }
    }
}