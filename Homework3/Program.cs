// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 


Console.WriteLine("введите целое число");
int number = int.Parse(Console.ReadLine());

if(number<=5)
{
    Console.WriteLine("Нет");
}
else if(number <= 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("введите число от 1 до 7");
}