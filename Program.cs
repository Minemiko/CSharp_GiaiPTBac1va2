using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double a, b;
        Console.Write("Nhập số a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số b: ");
        b = Convert.ToDouble(Console.ReadLine());
        string ketqua1 = GiaiPTBac1(a, b);
        Console.WriteLine(ketqua1);

        double x, y, z;
        Console.Write("Nhập số x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số z: ");
        z = Convert.ToDouble(Console.ReadLine());
        string ketqua2 = GiaiPTBac2(x, y, z);
        Console.Write(ketqua2);
    }

    private static string GiaiPTBac1(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                return "Phương trình vô số nghiệm";
            }
            else
            {
                return "Phương trình vô nghiệm";
            }
        }
        else
        {
            return "Nghiệm của phương trình x là " + (-b / a);
        }    
    }

    private static string GiaiPTBac2(double x, double y, double z) {
        if (x == 0) {
            if (y == 0) {
                if (z != 0) {
                    return "Phương trình vô nghiệm";
                } else {
                    return "Phương trình vô số nghiệm";
                }
            } else {
                return "Nghiệm của phương trình x là " + (-z / y);
            }
        } else
        {
            double delta = y * y - 4 * x * z;
            if (delta < 0) {
                return "Phương trình vô nghiệm";
            } else {
                Console.WriteLine("x1 = " + (-y + (Math.Sqrt(delta)) / (2 * x)));
                Console.WriteLine("x2 = " + (-y - (Math.Sqrt(delta)) / (2 * x)));
            }
        } return "";
    }
}