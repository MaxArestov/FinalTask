﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
Console.Clear();
Console.WriteLine("Введите число, означающее количество элементов массива строк:");
int num = GetNumber();
string[] arrayStrings = new string[num];
FillArray(arrayStrings);
PrintArray(arrayStrings);
string[] newArr = GetArrayThreeLength(arrayStrings);
PrintArray(newArr);




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

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент:");
        arr[i] = Console.ReadLine().ToString();
    }
}

void PrintArray(string[] arr)
{
    Console.WriteLine("Элементы массива:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] GetArrayThreeLength(string[] arr)
{
    int newNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newNumber++;
        }
    }
    string[] newArray = new string[newNumber];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[j] = arr[i];
            j++;
        }
    }
    return newArray;
}