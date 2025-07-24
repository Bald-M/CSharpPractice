namespace variable_type_conversion;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        float height = 0.76f;
        height += 1;

        string content = $"我的身高是：{height}";
        Console.WriteLine(content);

        // 隐式类型转换
        int a = 4;
        float f = a * 1.0f / 3;
        Console.WriteLine(f);
        
        // 强制类型转换
        int b = (int) f;
        Console.WriteLine(b); 

        // 输入一个数字打印它乘以2的结果
        /*int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number * 2);
        
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num * 2);*/

        string aa = "hello";
        int bb = 1;
        aa = aa + bb + 2 + 3;
        Console.WriteLine(aa);


    }
}