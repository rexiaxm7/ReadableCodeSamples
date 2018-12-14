namespace Sample2
{
    // ローカル変数の再代入
    public class DesignPatternSample
    {
        public static int Calculate(int price, bool isTakeout)
        {
            // 変数の代入は初期化時のみで行っており、計算が入るたびに
            // 変数名がわかるため流れが追いやすく、処理に名前を付けやすい。
            var taxRate = isTakeout ? 0.08d : 0.10d;

            return (int)(price * taxRate);
        }
    }
}