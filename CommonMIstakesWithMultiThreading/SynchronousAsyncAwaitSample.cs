using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonMistakesWithMultiThreading
{
    internal class WorldConquer
    {
        public async Task PlotDominationAsync()
        {
            Console.WriteLine("PlotDominationAsync");
        }
        public async Task DeployTroopsAsync()
        {
            Console.WriteLine("DeployTroopsAsync");
        }
        public async Task EstablishEvilHeadquartersAsync()
        {
            Console.WriteLine("EstablishEvilHeadquartersAsync");
        }
        public async Task LaunchDeathRayAsync()
        {
            Console.WriteLine("LaunchDeathRayAsync");
        }

        public async Task LaunchSample()
        {
            await PlotDominationAsync();
            await DeployTroopsAsync();
            await EstablishEvilHeadquartersAsync();
            await LaunchDeathRayAsync();
        }

        public async Task LaunchFixedSample()
        {

            //Parallel.Invoke(parallelOptions:new ParallelOptions()
            //{
                
            //});
            await Task.WhenAll(
                PlotDominationAsync(),
                DeployTroopsAsync(),
                EstablishEvilHeadquartersAsync(),
                LaunchDeathRayAsync()
            );
        }

    }


}
