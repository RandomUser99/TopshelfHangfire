using Topshelf;

namespace TopshelfHangfireDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(config =>
            {
                config.Service<BootStrap>(service =>
                {
                    service.ConstructUsing(x => new BootStrap());
                    service.WhenStarted(x => x.Start());
                    service.WhenStopped(x => x.Stop());
                });

                config.RunAsLocalSystem();
                config.SetDescription("Topshelf service");
                config.SetDisplayName("TopShelfService");
            });
        }
    }
}
