
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


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

//определение нечётных чисел в массиве, определение суммы нечётных чисел в массиве

int  OddNumbers (int [] array)

{
        int len = array.Length;
        int []result = new int [len];
        int res = 0;
        for (int i = 0; i < len; i ++)
        {
              if (array [i] % 2 > 0)
              {
                result[i] = array[i];
                res += result[i];
              }         
                              
        }
            return res;
}  
        


//печать массива в консоль

void PrintArray (int res)
{
    Console.WriteLine(res);
}
           
           
int [] inArr = CreateArray (16);
FillRandomArray (inArr, -10, 4);
int res = OddNumbers (inArr);
PrintArray (res);           
         
           
         