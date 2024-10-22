using UnityEngine;

public class SelectionSortUI : MonoBehaviour
{
    SelectionSort selectionSort = new SelectionSort();
    [SerializeField] int[] array;

    void Start()
    {
        int[] result = selectionSort.SelectionSortFunction(array);
        string resultText = "";
        
        foreach (var item in result)
        {
            resultText += item + " ";
        }
        Debug.Log("選択ソートの結果は以下の通りです。\n" + resultText);
    }
}
