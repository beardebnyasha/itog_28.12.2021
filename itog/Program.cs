int[] CreatNewArray (int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
    {
        System.Console.Write(el + " ");
    }
}

PrintArray(CreatNewArray(10));