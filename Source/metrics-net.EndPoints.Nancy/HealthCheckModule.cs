using System.Linq;
using Nancy;
using metrics;

namespace metrics_net.EndPoints.Nancy
{
    public class HealthCheckModule : NancyModule
    {
        public HealthCheckModule()
        {
            Get["/HealthCheck"] = parameters =>
            {
                var health = HealthChecks.RunHealthChecks();
                var response = Response.AsJson(health);
                response.StatusCode = health.Values.Count(v => v.IsHealthy) != health.Values.Count ? HttpStatusCode.InternalServerError : HttpStatusCode.OK;

                return response;
            };
        }
    }
}
