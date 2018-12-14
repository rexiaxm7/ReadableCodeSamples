namespace Sample1
{
    // 早期リターン
    public static class AntiPatternSample
    {
        // 価格と重さから送料を足した価格を返すメソッド
        public static int Calculate(int price, int weight)
        {
            if (price >= 5000)
            {
                return price;
            }
            else
            {
                // ここのもっと処理が長いと、読みづらい
                var postage = weight * 100;
                return price + postage;
            }
        }
    }
}
