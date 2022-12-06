//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите 2 числа A и B:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int result = 1; 
    for (int count = 0; count < B; count++)

{
    result = result * A;
}

Console.WriteLine($"{result}");