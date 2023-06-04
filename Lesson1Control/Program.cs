///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///
// выводит сообщение и читает число с консоли
int ReadFromConsole (string message)
{
    Console.Write (message + ": ");
    return Convert.ToInt32 (Console.ReadLine ());
}

///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///
// выводит массив в консоль
void PrintArray (string[] arrayToWrite)
{
    for (int i = 0; i < arrayToWrite.Length; i++)
    {
        Console.Write (i + ": " + arrayToWrite[i] + " |");
    }
    Console.WriteLine ();
}

///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///
// заполняет массив c клавиатуры
string[] FillArrayManual ()
{
    string[] arrayManual;
    int arraySize = ReadFromConsole ("Введи размер массива");
    arrayManual = FillArrayManualArgs (arraySize);

    return arrayManual;
}
///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///     ///
// заполняет массив c клавиатуры (с параметрами)
string[] FillArrayManualArgs (int arraySize)
{
    string[] arrayManual = new string[arraySize];


    for (int i = 0; i < arraySize; i++)
    {
        Console.Write ($"Введи {i + 1} элемент: ");
        arrayManual[i] = Console.ReadLine ();
    }
    //PrintArray (arrayManual);
    return arrayManual;
}
//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
string[] array = FillArrayManual ();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 3)
    {
        count++;
    }
}
string[] resultArray = new string[count];
for (int i = 0, j = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultArray[j] = array[i];
        j++;
    }
}
PrintArray (array);
Console.WriteLine ();
PrintArray (resultArray);
Console.ReadLine ();