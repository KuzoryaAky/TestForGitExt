﻿namespace TestGenericExtention
{
    internal class Program : Generic<TestInteface>
    {
        static void Main(string[] args)
        {

        }


        static void StopWatchTest()
        {
            //стопвотч тест для бенчмарка методов с дебагом

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //sw.Stop();  

            //var ts = sw.Elapsed;

            //Debug.WriteLine(String.Format("new Method {0:00}:{1:00}:{2:00}.{3:00}",
            //                 ts.Hours, ts.Minutes, ts.Seconds,
            //                 ts.Milliseconds / 10));
        }

        public override Task<bool> InitializeAsync(TestInteface orders, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }
    }
}
