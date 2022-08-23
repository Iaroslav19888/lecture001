//  Вид 1 (ничего не возвращают и не принмиают)

void Method1()
{
    Console.WriteLine("Автор: Селютин Ярослав Юрьевич");
}

// как вызываются?
Method1(); 

// Вид 2 (ничего не возвращают, но могут принимать аргументы)

void Method2 (string msg) // (в скобочках аргументы)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");


// Вид 3 - которые что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 - что-то принимает, что-то возвращают

// string Method4(int count, string text) // возвращаем строку, передаем ..... будем символ "text" компоновать count раз  
// {
//     int i = 0;
//   string result = String.Empty; // а можно просто поставить ""

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4 (10, "qwerty");
// Console.WriteLine(res);

// или


string Method4(int count, string text) // возвращаем строку, передаем ..... будем символ "text" компоновать count раз  
{
    string result = String.Empty; // а можно просто поставить ""
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

// цикл в цикле (вывод таблицы умножения на экран)


    for (int i = 2; i <= 10; i++)
    {
       for (int j = 2; j <= 10; j++)
       {
            Console.WriteLine($"{i}*{j} = {i * j}");
       }
       Console.WriteLine(); // переход на новую строку
    }
  

  // Работа с текстом
  // Дан текст. В тексте нужно все пробелы заменить черточками
  // Маленькие буквы "к" заменить большими
  // А большие "С" на маленькие

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
//

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

String newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);


// алгоритм сортировки методом выбора (минимакса)
///
////
/////

int[] arr = { 1, 5, 4, 1, 3, 2, 7};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if (array[j] < array [minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);