int GetIntValue(int min,int max)
{
    return new Random().Next(min,max);
}
//Console.WriteLine(GetIntValue(10,20));

int[] CreateArray(int size)
{
    return new int[size];
}
void Fill(int[] array)
{
    int size = array.Length;
    int i =0;
    while(i<size)
    {
        array[i] = GetIntValue(1,10);
        i++;
    
    }
}
void Print( int[] array)
{
    int i =0;
    int size = array.Length;
    while(i <size)
    {
        Console.Write(array[i]+ " ");
        i++;

    }
    Console.WriteLine();
}
int SearchNumbers(int[] array)
{
    int count = 0;
    int size = array.Length;
    int i = 0;
    while(i<size)
    {
        if( array[i]%2 == 0)
        {
            count+=1;
        }
        i++;

    }
    return count;
}
int[] Final(int[] data, int count)
{
    int[] EvenItems = new int[count];
    int position = 0;
    int i = 0;
    int size = data.Length;
    while( i<size)
    {
        if (data[i]%2 == 0)
        {
            EvenItems[position] = data[i];
            position++;
        }
        i++;
    }
    return EvenItems;
}
int[] col = CreateArray(GetIntValue(5,10));
Print(col);
Fill(col);
Print(col);
int count = SearchNumbers(col);
int[] result = Final(col,count);
Print(result);
