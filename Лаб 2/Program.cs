try
{
    Console.Write("Введите переменную e: ");
    double e = double.Parse(Console.ReadLine());
    const double a = 2;
    const double p = 2.6;

    double t = (Math.Pow(p, 3)) + (Math.Pow(a, 3));
    double x = Math.Pow(e, (Math.Sqrt(p + a)));
    double y = (Math.Pow(x, 3)) / (Math.Pow(t, 2));

    Console.WriteLine($"t = {t:F2}, x = {x:F2}, y = {y:F2}");
}
catch
{
    Console.WriteLine("Введите правильно!");
}
