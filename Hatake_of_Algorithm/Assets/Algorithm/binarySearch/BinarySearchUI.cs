using UnityEngine;

public class BinarySearchUI : MonoBehaviour
{
    private BinarySearch binarySearch = new BinarySearch();
    [SerializeField] private int[] array;
    [SerializeField] private int target;

    void Start()
    {
        int result = binarySearch.BinarySearchFunction(array, target);
        Debug.Log($"二分探索の結果、探索したい値の位置は{result}にあります。");
    }
}
