using TRPO_Lab3.Library;

    Console.Write("Введите радиус: ");
    double radius = double.Parse(Console.ReadLine());
    Console.Write("Введите угол в градусах: ");
    double angleInDegrees = double.Parse(Console.ReadLine());
    double area = MathLib.CalculateSphereSectorSurfaceArea(radius, angleInDegrees);
    Console.WriteLine("Площадь поверхности шарового сектора: " + area);


