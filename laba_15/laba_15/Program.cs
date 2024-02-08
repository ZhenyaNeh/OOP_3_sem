namespace laba_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixMultiply.Multiply();      // 1, 2
            SomeTask.TaskOperation();       // 3, 4
            ParFor.ParallelForForeach();    // 5
            ParalelInvoke.ParlInvoke();     // 6
            Supplies.SuppliesProd();        // 7
            //Deliver.deliverProduct();
            TestAsync.TestAsyncMethods();   // 8
        }
    }
}