// // Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = new string[] { "1234", "1567", "-2", "hi", ":-)", "computer science" };
string[] result = new string[array.Length];

int element = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result[element] = array[i];
        element++;
    }
}
if (element > 0)
{
    Console.Write("Новый массив с элементами длиной 3 или менее символов: [");
    for (int i = 0; i < element - 1; i++)
    {
        Console.Write($"{result[i]}, ");
    }
    Console.Write($"{result[element - 1]}]");
}
else
{
    Console.WriteLine("в массиве нет строк длиной 3 или менее символов");
}

