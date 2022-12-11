// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
Console.Clear();
Console.WriteLine("Введите число, означающее количество элементов массива строк:");
int num = GetNumber();
string[] arrayStrings = new string[num];





int GetNumber()
{
    int number = new int();
    bool check = true;
    while (check)
    {
        bool isParsed = int.TryParse(Console.ReadLine(), out number);
        if (!isParsed)
        {
            Console.WriteLine("Введены некорректные данные. Введите целое число:");
        }
        else check = false;
    }
    return number;
}