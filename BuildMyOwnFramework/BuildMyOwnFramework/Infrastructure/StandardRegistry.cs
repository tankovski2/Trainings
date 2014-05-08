using StructureMap.Configuration.DSL;

namespace BuildMyOwnFramework.Infrastructure
{
    public class StandardRegistry:Registry
    {
        public StandardRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
        }
    }
}