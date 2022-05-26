using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test : MonoBehaviour
{
    int[] array = {1, 4, 6, 3, 7, 8, 10, 2, 5, 9};
    public static int lIndex = 0;                                                //индекс левого массива 
    public static int rIndex = 0;                                                //индекс правого массива

    static int mainIndex;                                      //индекс главного массива
    void Start()
    {
       
       int[] a = Split(array);
       int[] b = Splitr(array);

       int[] c = MergeSort(a, b);

       for(int i = 0; i < c.Length; i++){
           Debug.Log(c[i]);
       }


        
        
    }

    


    public static int[] Split(int[] array){
        int[] lNums = new int[array.Length/2];
        int[] rNums = new int[array.Length/2];

        int mid = array.Length/2;

        // Debug.Log(mid);

        for(int i = 0; i < lNums.Length; i++){
            lNums[i] = array[i];
        }

        for(int i = 0; i < rNums.Length; i++){
            rNums[i] = array[mid];
            mid++;
        }

        Array.Sort(lNums);
        Array.Sort(rNums);
        

        return lNums;
        // return rNums;
        

        
        // for(int i = 0; i < lNums.Length; i++){
        //     Debug.Log(lNums[i]);
            
        // }
        // for(int i = 0; i < rNums.Length; i++){
        //     Debug.Log(rNums[i]);
            
        // }
    }

    public static int[] Splitr(int[] array){
        int[] lNums = new int[array.Length/2];
        int[] rNums = new int[array.Length/2];

        int mid = array.Length/2;

        // Debug.Log(mid);

        for(int i = 0; i < lNums.Length; i++){
            lNums[i] = array[i];
        }

        for(int i = 0; i < rNums.Length; i++){
            rNums[i] = array[mid];
            mid++;
        }

        Array.Sort(lNums);
        Array.Sort(rNums);
        

        // return lNums;
        return rNums;
        

        
        // for(int i = 0; i < lNums.Length; i++){
        //     Debug.Log(lNums[i]);
            
        // }
        // for(int i = 0; i < rNums.Length; i++){
        //     Debug.Log(rNums[i]);
            
        // }
    }

    public static int[] MergeSort(int[] lNums, int[] rNums){
        int[] nums = new int[lNums.Length + rNums.Length];
        for(int i = 0; i < nums.Length; i++){                                     //сравнение чисел по индексом, 
            if(lNums[lIndex] < rNums[rIndex]){                                    //до того как закончится один из массивов
                nums[i] = lNums[lIndex];
                ++lIndex;
            } else{
                nums[i] = rNums[rIndex];
                ++rIndex;
            }

            mainIndex = i;
            
            if(lIndex >= lNums.Length || rIndex >= rNums.Length){                      // выход из цыкла если закончится
                break;                                                                 // один из массивов
            }
        }
        
        if(rIndex >= rNums.Length){                                                       //добавление чисел в главный массив
            for(int i = mainIndex + 1; i < nums.Length; i++){                             // если закончится правый массив
                nums[i] = lNums[lIndex];
                lIndex++;
            }

        }
        else
        {
            for(int i = mainIndex + 1; i < nums.Length; i++){
                nums[i] = rNums[rIndex];
                rIndex++;
            }
        }
        
        // for(int i = 0; i < nums.Length; i++){                                       //вывод массива
        //     Debug.Log(nums[i]);
        // }

        return nums;
    }

    
}
