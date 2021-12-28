int[] CreatNewArray (int lenght, int firstNum, int lustNum)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(firstNum, lustNum);
    }
return array;
}
