using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_15
{
    class SomeTask
    {
        public static async void TaskOperation()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--------Some_Task--------");
            Console.ResetColor(); 

            var result1 = await AddAsync(4, 5);
            var result2 = await MulAsync(4, 5);
            var result3 = await DelAsync(10, 5);
            var result4 = await SumAsync(result1, result2, result3);
            Console.WriteLine(result4);

            async Task<int> AddAsync(int a, int b)
            {
                return a + b;
            }

            async Task<int> MulAsync(int a, int b)
            {
                return a * b;
            }

            async Task<int> DelAsync(int a, int b)
            {
                return a / b;
            }

            async Task<int> SumAsync(int a, int b, int c)
            {
                return a + b + c;
            }

            Task task1 = new Task(() => Console.WriteLine($"Current Task: {Task.CurrentId}"));

            Task task2 = task1.ContinueWith(t =>
                Console.WriteLine($"Current Task: {Task.CurrentId}  Previous Task: {t.Id}"), TaskContinuationOptions.NotOnRanToCompletion);

            Task task3 = task2.ContinueWith(t =>
                Console.WriteLine($"Current Task: {Task.CurrentId}  Previous Task: {t.Id}"));


            Task task4 = task3.ContinueWith(t =>
                Console.WriteLine($"Current Task: {Task.CurrentId}  Previous Task: {t.Id}"));

            task1.Start();

            task4.Wait();


            Task<int> what = Task.Run(() => Enumerable.Range(1, 100000).Count(n => (n % 2 == 0)));

            var awaiter = what.GetAwaiter();
            
            awaiter.OnCompleted(() => {
                int res = awaiter.GetResult();
                Console.WriteLine(res);
            });
            what.Wait();

            async Task<int> GetOneAsync()
            {
                await Task.Delay(1000);
                return 11111;
            }
            int one = GetOneAsync().GetAwaiter().GetResult();
            Console.WriteLine(one);
        }
    }
}
