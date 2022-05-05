//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


//создать массив

int [] CreateArray (int count)

{
    int[] result = new int [count];
    return result;
}

//заполнить массив
  
void FillRandomArray (int [] array, int min, int max)

{
    int len = array.Length;

    for (int i = 0; i < len; i ++)
    {
        array[i] = new Random ().Next (min,max+1);
    }  
        
}

//определение четных чисел в массиве, определение колличества четных чисел в массиве

int EvenNumbers (int [] array)

{
        int len = array.Length;
        //int []result = new int [len];
        int res = 0;
        for (int i = 0; i < len; i ++)
        {
              if (array [i] % 2 == 0)
              {
                //result[i] = array[i];
                res +=1;  
              } 
              
                                
        }
            return res;
          
        
}   

//печать массива в консоль

void PrintArray (int res)
{
    Console.WriteLine(res);
}
           
           
int [] inArr = CreateArray (899);
FillRandomArray (inArr, 100, 1000);
int res = EvenNumbers (inArr);
PrintArray (res);           
         
           
         