using StructureMap.Configuration.DSL;

namespace BuildMyOwnFramework.Infrastructure
{
    public class ControllerRegistry:Registry
    {
        public ControllerRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.With(new ControllerConvention());
            });
        }
    }
}