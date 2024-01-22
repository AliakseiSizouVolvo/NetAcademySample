namespace CommonMistakesWithMultiThreading
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //var worldConquer = new WorldConquer();
            //await worldConquer.LaunchSample();


            //collection
            //var ntscs = new NotThreadSafeCollectionSample();

            //var taskList = new List<Task>()
            //{
            //    new(() => ntscs.AddData(new Model() { Id = 1 })),
            //    new(() => ntscs.AddData(new Model() { Id = 2 })),
            //    new(() => ntscs.AddData(new Model() { Id = 3 })),
            //    new(() => ntscs.GetData(2)),
            //    new(() => ntscs.RemoveData(2)),
            //    new(() => ntscs.AddData(new Model() { Id = 5 })),
            //};
            //foreach (var task in taskList)
            //{
            //    task.Start();
            //}
            //await Task.WhenAll(taskList);
            //var x = 0;

            //var lockerSample = new LockBestPracticesSample();
            //lockerSample.WriteToSmth();

            var fileSample = new FileIOIssues();
            await fileSample.LaunchSample();

        }
    }
}
