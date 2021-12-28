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
    foreach (int index in array)
    {
        System.Console.Write(index + " ");
    }
}


int[] NewArray(int[] array)
{
    int NewArrayLenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            NewArrayLenght++;
        }
    }
    int[] NewArray = new int[NewArrayLenght];
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            NewArray[number] = array[i];
            number++;
        }
    }
    return NewArray;
}
int[] Resultarray;

System.Console.Write("Первоначальный массив: ");
Resultarray = CreatNewArray(10);
PrintArray(Resultarray);
System.Console.WriteLine(" ");
System.Console.Write("Результирующий массив: ");
PrintArray(NewArray(Resultarray));