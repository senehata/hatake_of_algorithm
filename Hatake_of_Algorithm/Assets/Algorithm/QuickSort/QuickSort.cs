//QuickSort
//クイックソート

public class QuickSort
{
    public int[] Sort(int[] array, int left, int right)
    {
        // 配列の要素が2つ以上ある場合のみ処理を行う
        if (left < right)
        {
            // 中央の要素のインデックスを計算
            // (right + left) / 2 ではなく、オーバーフロー対策のためこの方法を使用
            int mid = left + (right - left) / 2;
            int pivot = array[mid];
            
            // ピボットを右端に一時的に移動
            (array[right], array[mid]) = (array[mid], array[right]);

            // パーティションのインデックス（ピボットより小さい要素の最後尾）
            int i = left - 1;

            // 配列をスキャンしてパーティション処理を行う
            // ピボットより小さい要素は左側に、大きい要素は右側に集める
            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    // ピボットより小さい要素を左側に移動
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }

            // ピボットを正しい位置（パーティションの境界）に移動
            int pivotPos = i + 1;
            (array[pivotPos], array[right]) = (array[right], array[pivotPos]);

            // ピボットの左側をソート（再帰呼び出し）
            Sort(array, left, pivotPos - 1);
            // ピボットの右側をソート（再帰呼び出し）
            Sort(array, pivotPos + 1, right);
        }

        return array;
    }
}