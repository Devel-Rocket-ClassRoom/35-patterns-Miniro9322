using System;

// README.md를 읽고 코드를 작성하세요.
Shape circle1 = new Circle { Raduis = 5 };
Shape circle2 = new Circle { Raduis = 15 };
Shape rectangle1 = new Rectangle { Width = 4, Height = 6 };
Shape rectangle2 = new Rectangle { Width = 5, Height = 5 };
Shape square = new Square { Side = 7 };


Console.WriteLine("=== 도형 분류기 ===");

Console.WriteLine($"원(반지름: 5): {ClassifyShape(circle1)}, 넓이: {CalculateArea(circle1):f2}");
Console.WriteLine($"원(반지름: 15): {ClassifyShape(circle2)}, 넓이: {CalculateArea(circle2):f2}");
Console.WriteLine($"직사각형(4x6): {ClassifyShape(rectangle1)}, 넓이: {CalculateArea(rectangle1):f2}");
Console.WriteLine($"직사각형(5x5): {ClassifyShape(rectangle2)}, 넓이: {CalculateArea(rectangle2):f2}");
Console.WriteLine($"정사각형(7): {ClassifyShape(square)}, 넓이: {CalculateArea(square):f2}");

double CalculateArea(Shape shape) => shape switch
{
    Circle { Raduis: var r } => Math.PI * r * r,
    Rectangle { Width: var w, Height: var h } => w * h,
    Square { Side: var s } => s * s
};

string ClassifyShape(Shape shape) => shape switch
{
    Circle { Raduis: < 10 } => "작은 원",
    Circle { Raduis: >= 10 } => "큰 원",
    Rectangle { Width: var w, Height: var h } => w == h ? "정사각형 모양의 직사각형" : "일반 직사각형",
    Square => "정사각형"
};