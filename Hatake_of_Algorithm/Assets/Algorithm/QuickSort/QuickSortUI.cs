using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSortUI : MonoBehaviour
{
    private QuickSort quicksort = new QuickSort();
    [SerializeField] int[] array;

    void Start()
    {
        int[] result = quicksort.Sort(array, 0, array.Length - 1);
        string resultText = "";
        
        foreach (var item in result)
        {
            resultText += item + " ";
        }
        Debug.Log("クイックソートの結果は以下の通りです。\n" + resultText);
    }

    

}
