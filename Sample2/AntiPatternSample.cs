namespace Sample2
{
    // ローカル変数の再代入
    public class AntiPatternSample
    {
        public static int Calculate(int price, bool isTakeout)
        {
            var taxRate = 0.1d;

            if (isTakeout)
            {
                // ローカル変数を再代入すると流れがわかりにくく、可読性が落ちるケースが多い。 
                // 言語によってはfinalやvalで再代入禁止にできるケースもあるので
                // 例外(カウントアップやフラグ)を除いては再代入不可にしておく事が望ましい。
                taxRate = 0.08;
            }

            return (int) (price * taxRate);
        }
    }
}
