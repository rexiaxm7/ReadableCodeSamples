namespace Sample1
{
    // 早期リターン
    public static class DesignPatternSample
    {
        // 価格と重さから送料を足した価格を返すメソッド
        public static int Calculate(int price, int weight)
        {
            if (price >= 5000) return price;

            // ifのスコープから解放されているので意識しなくて済む
            var postage = weight * 100;
            return price + postage;
        }
    }
}