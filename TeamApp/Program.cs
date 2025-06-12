using TeamApp;

var calculator = new ShapeCalculator();

double circleArea = calculator.CalculateCircleArea(5);
double squareArea = calculator.CalculateSquareArea(4);
double triangleArea = calculator.CalculateTriangleArea(6, 3);

Console.WriteLine($"Circle area: {circleArea}");
Console.WriteLine($"Square area: {squareArea}");
Console.WriteLine($"Triangle area: {triangleArea}");