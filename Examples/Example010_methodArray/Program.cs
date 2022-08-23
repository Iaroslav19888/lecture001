int[] array = {1,23,65,77,34,23,2,4,6,77}; // определяем новый массив

int n = array.Length; // задаем длину массива
int find = 23; // что ищем?

int index = 0; // начало массива

while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index); // показываем значение индекса
        break; //чтобы второй такой же не искал
    }
    //index = index+1;
    index++;
}