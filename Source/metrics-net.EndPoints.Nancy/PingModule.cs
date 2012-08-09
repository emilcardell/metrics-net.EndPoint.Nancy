using Nancy;

namespace metrics_net.EndPoints.Nancy
{
    public class PingModule : NancyModule
    {
        public PingModule()
        {
            Get["/ping"] = parameters => "pong";
        }
    }
}
