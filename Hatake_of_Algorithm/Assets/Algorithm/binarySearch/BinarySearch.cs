//2024.10.19

//Binary Search
//二分探索
public class BinarySearch
{
    /// <summary>
    /// 二分探索
    /// ソート済みの配列の中から、探索したい値が配列の中でどの位置にあるかを探索する。
    /// </summary>
    /// <param name="array">探索する配列を入れる</param>
    /// <param name="target">探索したい値を入れる</param>
    /// <returns></returns>
    public static int BinarySearchFunction(int[] array, int target)
    {
        int left = 0; //探索する配列の最小の値の位置。探索中に動的に変化する。
        int right = array.Length - 1; //探索する配列の最大の値の位置。探索中に動的に変化する。

        while (left <= right)
        {
            int middle = left + (right - left) / 2; 

            if (array[middle] == target)
            {
                return middle;
            }
            else if (array[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1; // 要素が見つからない場合
    }
}
