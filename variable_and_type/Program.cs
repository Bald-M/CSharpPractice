namespace variable_and_type;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 3 + 7;
        int num2 = num1 + 1; 
        Console.WriteLine($"{num1} + {num2}  = {num1 + num2}");

        num2 = num2 - num1;
        Console.WriteLine($"{num2} - {num1}  = {num2 - num1}");
        
        int num3 = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {num3}");
        
        int num4 = num1 / 3;
        Console.WriteLine($"{num1} / 3 = {num4}");

        Console.WriteLine($"10 % 3 = {10 % 3}");
        Console.WriteLine($"7 % 4 = {7 % 4}");

        int score = 90;
        score += 3;
        Console.WriteLine($"Score: {score}");

        int attack = 0;
        Console.WriteLine($"Attack Before: {attack}");
        attack++;
        Console.WriteLine($"Attack After: {attack}");
        
        // 浮点
        float f = 3.14f;
        double d = 3.14;

        string name = "Peter";
        Console.WriteLine($"Name: {name}");

        string job = Console.ReadLine();
        Console.WriteLine($"Job: {job}");

    } 
}