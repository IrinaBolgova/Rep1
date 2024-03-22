using TRPO_Lab3.Library;

    Console.Write("Введите радиус шара: ");
    double radius_shara = double.Parse(Console.ReadLine());
    Console.Write("Введите радиус окружности: ");
    double radius_okrujnosti = double.Parse(Console.ReadLine());
    Console.Write("Введите высоту: ");
    double height = double.Parse(Console.ReadLine());
    double area = MathLib.CalculateSphereSectorSurfaceArea(radius_shara, radius_okrujnosti, height);
    Console.WriteLine("Площадь поверхности шарового сектора: " + area);


