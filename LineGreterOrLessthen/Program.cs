namespace LineCompersion
{
    class Program
    {
        public static void Main(String[] args)
        {
            LineCompersion result = new LineCompersion();
            double Value1 = result.Line();
            double Value2 = result.LineTwo();

            if (Value1 == Value2)
            {
                Console.WriteLine("Line is Equal");
            }
            else if (Value1 > Value2)
            {
                Console.WriteLine("LineOne  is Greater of LineTwo ");
            }
            else
            {
                Console.WriteLine("LineOne is LessThen of LineTwo ");
            }
        }
    }
}