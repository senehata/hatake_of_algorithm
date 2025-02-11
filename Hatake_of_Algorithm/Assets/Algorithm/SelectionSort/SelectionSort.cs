//選択ソート
//Selection Sort

public class SelectionSort
{
    public int[] SelectionSortFunction(int[] array)
    {
        int n = array.Length;

        //配列の要素が低い順から、小さい値を見つけて代入していく。
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            // 未ソート部分から最小値を見つける
            for (int j = i + 1; j < n; j++)
            {
                //最小値のインデックスを記録、更新していく。
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // 見つかった最小値と未ソート部分の先頭要素を交換
            if (minIndex != i)
            {
                (array[i], array[minIndex]) = (array[minIndex], array[i]);
            }
        }

        return array;
    }
}