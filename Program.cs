// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string Polindrome (int number){
    string arr = number.ToString();
    string result = number + " - полендром";
    for (int i = 0; i < arr.Length/2; i++ ){
        if (arr[i] != arr[arr.Length - 1 - i]) {
            // Console.Write("$ {arr[i]} : {arr[arr.Length - 1 - i]}");
            result = number + " - не полендром";
            break;
        }
    }
    return result;
}

Console.WriteLine("------- Вывод результата по палиндрому");
string a = Polindrome(12821);
Console.Write(a);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Distance(double x1, double y1, double z1, double x2, double y2, double z2){
    double pre_result = Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2);
    double result = Math.Sqrt(pre_result);
    Console.WriteLine(result);
}
Console.WriteLine("------- Растояние между точек");
Distance(1,1,1,3,3,2);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Kub (double pow){
    for (int i=1; i<=pow; i++){
        double result = Math.Pow(i,3);
        Console.Write (i == pow ? result : $"{result}, ");
    }
}
Kub(3);
