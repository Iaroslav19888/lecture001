int[] array = {1,23,65,77,34,23,2,4,6,77};

int n = array.Length;
int find = 23;

int index = 0;

while (index<n)
{
    if(array[index]== find)
    {
        Console.WriteLine(index);
        break; //чтобы второй такой же не искал
    }
    //index = index+1;
    index++;
}