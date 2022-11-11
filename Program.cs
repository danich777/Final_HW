//Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых
//меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнение алгоритма. При решени не рекомендуется пользоваться коллекциями, лучше обойтись 
//исключительно массивами.

Console.Write("Введите количество элементов массива: ");
int count = Int32.Parse(Console.ReadLine()!);

string[] FirstArray = new string[count];

int Number = 0;
for (int i = 0; i < count; i++)
{
    Console.Write($"Введите элемент номер №{i + 1} ");
    FirstArray[i] = Console.ReadLine();
    if (FirstArray[i].Length <= 3) { Number++; }
}

string[] SecondArray = new string[Number];
FillSecondArray(FirstArray, SecondArray);

Console.WriteLine($"[{String.Join(", ", FirstArray)}]");
Console.WriteLine($"[{String.Join(", ", SecondArray)}]");

void FillSecondArray(string[] FirstArray, string[] SecondArray)
{
    int j = 0;
    for (int i = 0; i < count; i++)

    {
        if (FirstArray[i].Length <= 3)
        {
            SecondArray[j] = FirstArray[i];
            j++;
        }
    }
}