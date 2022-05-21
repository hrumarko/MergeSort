using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class JoinTwoArrays : MonoBehaviour
{
    static int[] lNums = {3, 6, 7, 9, 10};                     //левый массив
    static int[] rNums = {1, 2, 4, 5, 8};                      // правый массив

    static int lIndex = 0;                                                //индекс левого массива 
    static int rIndex = 0;                                                //индекс правого массива

    static int mainIndex;                                      //индекс главного массива
    int[] nums = new int[lNums.Length + rNums.Length];         //соединенный(главный) массив

    public void Start(){
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
        
        EndMassive();

        
        
        for(int i = 0; i < nums.Length; i++){                                       //вывод массива
            Debug.Log(nums[i]);
        }
    }

    public void EndMassive(){
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
    }
}
