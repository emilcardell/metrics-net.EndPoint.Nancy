using Nancy;
using metrics.Core;

namespace metrics_net.EndPoints.Nancy
{
    public class ThreadsModule : NancyModule
    {
        public ThreadsModule()
        {
            Get["Threads"] = parmeters => Response.AsJson(CLRProfiler.DumpTrackedThreads());
        }
       
    }
}
