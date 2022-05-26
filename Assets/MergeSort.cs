using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MergeSort : MonoBehaviour
{
    // int[] array = {1, 4, 6, 3, 7, 8, 10, 2, 5, 9};

    // public static int lIndex = 0;                                                //индекс левого массива 
    // public static int rIndex = 0;                                                //индекс правого массива

    // static int mainIndex;                                      //индекс главного массива
    //          //соединенный(главный) массив

    // public static void MergeSorting(int[] array, out int[] llNums, out int[] rrNums){

    //     int[] llNums = new int[array.Length/2];
    //     int[] rrNums = new int[array.Length/2];

    //     int mid = array.Length/2;

    //     for(int i = 0; i < llNums.Length; i++){
    //         lNums[i] = array[i];
    //     }

    //     for(int i = mid; i < rrNums.Length; i++){
    //         rrNums[i] = array[i];
    //     }

    //     Sort(llNums);

    //     for(int i = 0; i < llNums.Length; i++){
    //         Debug.Log(llNums[i]);
    //         Debug.Log(rrNums[i]);
    //     }

    // }


    // public static int[] Sorting(int[] lNums, int[] rNums){
    //     int[] nums = new int[lNums.Length + rNums.Length];
    //     for(int i = 0; i < nums.Length; i++){                                     //сравнение чисел по индексом, 
    //         if(lNums[lIndex] < rNums[rIndex]){                                    //до того как закончится один из массивов
    //             nums[i] = lNums[lIndex];
    //             ++lIndex;
    //         } else{
    //             nums[i] = rNums[rIndex];
    //             ++rIndex;
    //         }

    //         mainIndex = i;
            
    //         if(lIndex >= lNums.Length || rIndex >= rNums.Length){                      // выход из цыкла если закончится
    //             break;                                                                 // один из массивов
    //         }
    //     }
        
    //     EndMassive();

        
        
    //     for(int i = 0; i < nums.Length; i++){                                       //вывод массива
    //         Debug.Log(nums[i]);
    //     }
    // }

    // public void EndMassive(){
    //     if(rIndex >= rNums.Length){                                                       //добавление чисел в главный массив
    //         for(int i = mainIndex + 1; i < nums.Length; i++){                             // если закончится правый массив
    //             nums[i] = lNums[lIndex];
    //             lIndex++;
    //         }

    //     }
    //     else
    //     {
    //         for(int i = mainIndex + 1; i < nums.Length; i++){
    //             nums[i] = rNums[rIndex];
    //             rIndex++;
    //         }
    //     }
    // }
}
