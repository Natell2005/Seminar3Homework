// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// int num,r,sum=0,t;
// Console.Write("Введите пятизначное число: ");
// num = Convert.ToInt32(Console.ReadLine());
// if(num>9999 && num<100000)
// {
// for(t=num;num!=0;num=num/10)
// {
// r=num % 10;
// sum=sum*10+r;
// }
// if(t==sum)
// Console.Write($"{t} является палиндромом.");
// else
// Console.Write($"{t} не является палиндромом.");
// } else
// Console.Write("Введите пятизначное число! ");




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// формула растояние = scrt((x1 - x2) ^ 2 +  (y1 - y2) ^ 2 + (z1 - z2))
int enterValue (string prompt)
{
    Console.Write($"Введите координату точки {prompt}");
    int value = Convert.ToInt32(Console.ReadLine());

    return value;
}

int xa = enterValue("a по оси x: ");
int ya = enterValue("a по оси y: ");
int za = enterValue("a по оси z: ");
Console.WriteLine();
int xb = enterValue("b по оси x: ");
int yb = enterValue("b по оси y: ");
int zb = enterValue("b по оси z: ");
Console.WriteLine();

double distance = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2) + Math.Pow((za - zb),2));
Console.Write($"Расстояние между точками равно:{Math.Round(distance,2)}");
