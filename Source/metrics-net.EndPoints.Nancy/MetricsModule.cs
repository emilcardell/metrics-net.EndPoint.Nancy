using System;
using System.Linq;
using Nancy;

namespace metrics_net.EndPoints.Nancy
{
    public class MetricsModule : NancyModule
    {
        public MetricsModule()
        {
            Get["/Metrics"] = parameters => Response.AsJson(metrics.Metrics.All);

            Get["/Metrics/{metricName}"] = parameters => Response.AsJson(metrics.Metrics.All.Where(metric => metric.Key.Name.Equals(parameters.metricName, StringComparison.InvariantCultureIgnoreCase)));
        }
    }
}
