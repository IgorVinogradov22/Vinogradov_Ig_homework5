
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//создать массив

double[] CreateArray (int count)

{
    double[] result = new double [count];
    return result;
}

//заполнить массив
  
void FillRandomArray (double [] array, int min, int max)

{
    int len = array.Length;

    for (int i = 0; i < len; i ++)
    {
        array[i] = new Random ().Next (min , max+1);
    }  
        
}

//печать массива

void PrintArray (double[] array)


{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
       Console.Write($"{array[i]}"); 
    }
       Console.WriteLine();
}

//сортировка элементов массива

void  SelectionSort ( double [] array)

{
        int len = array.Length;
               
        
        for (int i = 0; i < len; i ++)
        {
             int minPosition = i;
             for (int j = i + 1; j < len; j++)
             {
                 if (array[j] < array[minPosition]) minPosition = j;
                 
             }    
                 double temporary = array [i];
                 array[i] = array[minPosition];
                 array[minPosition] = temporary;
        }       
}              
  
 
//вычисление разнорсти между мах и min элементами массива

double SpreadMaxMin (double[] array)

{      
    int len = array.Length;
    double spread = 0;
    
        for (int i = 0; i <= len; i++)
       
    {   
       spread = array[len-1] - array[0];
    }
   
        return spread;
     
}

//печать разности между max и min элементами массива

void PrintSpread (double spread)
{      
    
    Console.WriteLine ($"{spread} ");
     
}



double[] inArr = CreateArray (8);
FillRandomArray (inArr, 0 , 9);
PrintArray (inArr);
SelectionSort(inArr);
PrintArray (inArr);
double spread = SpreadMaxMin (inArr);
PrintSpread (spread);
