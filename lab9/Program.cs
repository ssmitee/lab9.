using System;

class MyClass
{
    private double field1;
    private double field2;

    public MyClass(double field1, double field2)
    {
        this.field1 = field1;
        this.field2 = field2;
    }

    public string GetInfo()
    {
        return $"Поле 1: {field1}, Поле 2: {field2}";
    }

    public double ProcessFields()
    {

        return Math.Pow(field1, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        double field1 = double.Parse(Console.ReadLine());
        double field2 = double.Parse(Console.ReadLine());

        MyClass obj = new MyClass(field1, field2);

        string info = obj.GetInfo();
        double result = obj.ProcessFields();

        Console.WriteLine(info);
        Console.WriteLine(result);
    }
}