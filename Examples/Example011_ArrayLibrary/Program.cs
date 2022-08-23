void FillArray(int[] collection) // метод создания массива
{
    int length = collection.Length; //получение массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10); 
        // обращаемся к аргументу collectin на позицию index и ложим туда новое случайное 
        // число из диапозона 1-10
        index++;
    }
}

void PrintArray(int[] col) // метод, который печатает массив // Void - метод, который ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // для поиска элемента в массиве
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // для отображения того, что искомого элемента в массиве нет

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // чтобы не указывало следующие одинаковые цифры
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // 1 - определили массив из 10 элементов

FillArray(array); // 2 - запустили первый метод, который заполнил массив
PrintArray(array); // 3 - запустили второй метод, который распечатал созданный массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);