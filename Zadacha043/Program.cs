// See https://aka.ms/new-console-template for more information

void crossLines(double k1, double b1, double k2, double b2){
    double xCross = 0;
    double yCross = 0;
    if (k1 != k2){
        xCross = (b2 - b1)/(k1 - k2);
        yCross = k1 * xCross + b1;
        Console.WriteLine($"Координаты точки пересечения прямых: ({xCross}, {yCross})");
    }
    else{
        Console.WriteLine("Прямые не пересекаются");
    }

}



Console.WriteLine("Введите коэфициент наклона первой прямой k1");
double k1 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициен первой прямой b1");
double b1 =Convert.ToDouble(Console.ReadLine());




Console.WriteLine("Введите коэфициент наклона первой прямой k2");
double k2 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициен первой прямой b2");
double b2 =Convert.ToDouble (Console.ReadLine());


crossLines(k1, b1, k2, b2);
