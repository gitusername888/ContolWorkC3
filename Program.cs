// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System.Runtime.Serialization.Formatters;

string[] InputArray ()
{
    System.Console.WriteLine("Введите количество значений массива:");
    int n = Convert.ToInt32(Console.ReadLine ());
    
    string [] arrayStart = new string [n];
    for (int i= 0; i <n; i++)
    {
        System.Console.WriteLine($"Введите {i}-e значение массива:");
        arrayStart [i] = Console.ReadLine ();

    }
    return arrayStart;
}

void PrintArray(string[] arrayStart)
{
 
    for (int i = 0; i < arrayStart.GetLength(0); i++)
    {
        System.Console.Write($"{arrayStart[i]}  ");
        
    }

}

string [] CheckArray (string [] arrayStart)
{
int count =0;
for (int i = 0; i<arrayStart.GetLength(0); i++)
{
    if (arrayStart[i].Length>=3)count++;
}
string [] arrayres = new string [count];
int countres = 0;
for (int j = 0; j<arrayStart.GetLength(0); j++)
{
    if (arrayStart[j].Length>=3)
    {
        arrayres [countres]= arrayStart[j];
        countres++;
    }
}

// string [] arrayResult = n

return arrayres;
}



string[] arrayStart =  InputArray ();
PrintArray(arrayStart);

string[] arrayres =  CheckArray (arrayStart);
PrintArray(arrayres);