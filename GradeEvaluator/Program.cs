using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 성적 평가기 ===");
Console.WriteLine($"95점: {GetGrade(95)} ({GetStatus(95)}) - {(IsPassingGrade(95) ? "합격" : "불합격")}");
Console.WriteLine($"87점: {GetGrade(87)} ({GetStatus(87)}) - {(IsPassingGrade(87) ? "합격" : "불합격")}");
Console.WriteLine($"73점: {GetGrade(73)} ({GetStatus(73)}) - {(IsPassingGrade(73) ? "합격" : "불합격")}");
Console.WriteLine($"65점: {GetGrade(65)} ({GetStatus(65)}) - {(IsPassingGrade(65) ? "합격" : "불합격")}");
Console.WriteLine($"45점: {GetGrade(45)} ({GetStatus(45)}) - {(IsPassingGrade(45) ? "합격" : "불합격")}");
Console.WriteLine($"30점: {GetGrade(30)} ({GetStatus(30)}) - {(IsPassingGrade(30) ? "합격" : "불합격")}");

char GetGrade(int score) => score switch
{
    >= 90 => 'A',
    >= 80 => 'B',
    >= 70 => 'C',
    >= 60 => 'D',
    _ => 'F'
};

string GetStatus(int score) => score switch
{
    >= 95 => "최우수",
    >= 90 => "우수",
    >= 70 => "보통",
    >= 40 => "노력 필요",
    _ => "재수강 권장"
};

bool IsPassingGrade(int score) => score is >= 60 and <= 100;