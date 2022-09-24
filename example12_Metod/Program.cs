#region 
//задать размер массива
int size = new Random().Next(5,10);
//задать массив:
int[] sourse = new int[size];
// заполнить массив:
for(int i=0; i<size; i++)
{
    sourse[i] = new Random().Next(1,15);
}
// распечатать исходный массив:
for(int i=0; i<size; i++)
{
    Console.Write(sourse[i] + " ");
}
#endregion
// найти количество четных:
int count = 0;
for(int i=0; i<size; i++)
{
    if( sourse[i]%2 == 0)
    {
        count+=1;
    }
}
//задать массив, в котором будут храниться четные числа:
int[] evenItems = new int[count];
//заполнить новый массив четными числами:
int pos = 0;
for(int i=0; i<size; i++)
{
    if(sourse[i]%2 == 0)
    {
        evenItems[pos] = sourse[i];
        pos++;
    
    }
}
System.Console.WriteLine();
//распечатать новый массив:
for(int i=0; i<count; i++)
{
    Console.Write(evenItems[i] + " ");
}

