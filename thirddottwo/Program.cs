Console.Write("Введите длинну 1 катета: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите длинну 2 катета: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите длинну гипотенузы: ");
double c = double.Parse(Console.ReadLine());

if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) Console.WriteLine("Треугольник прямоугольный");
else Console.WriteLine("Треугольник не прямоугольный");