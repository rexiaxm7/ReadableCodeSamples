namespace Sample3
{
    public class AntiPatternCalculator
    {
        private int _source1;
        private int _source2;
        private int _result;

        public int GetResult()
        {
            return _result;
    }

        public void SetValue(int source1, int source2)
        {
            _source1 = source1;
            _source2 = source2;
        }

        public void Calculate()
        {
            _result = _source1 + _source2;
        }
    }
}