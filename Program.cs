// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

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

string[] arrayStart =  InputArray ();
PrintArray(arrayStart);

