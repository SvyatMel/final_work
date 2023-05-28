void FillingTwoArray(string[] arrayOne,string[] arrayTwo)
{
    int j=0;
    for(int i=0;i<arrayOne.Length;i++)
    {
        if(arrayOne[i].Length<=3)
        {
            arrayTwo[j]=arrayOne[i];
            j++;
        }
    }
}
 void ShowArray(string[] arrayTwo)
 {
    for(int i=0;i<arrayTwo.Length;i++)
    {
        Console.Write(arrayTwo[i] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
 }
string[] array1 = new string[] {"sdsdsa" ,"dsdss" , "sadsad", "de"};
string[] array2 = new string[array1.Length];
FillingTwoArray(array1,array2);
ShowArray(array1);
ShowArray(array2);