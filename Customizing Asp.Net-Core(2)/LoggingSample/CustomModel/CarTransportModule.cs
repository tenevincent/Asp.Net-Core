using Autofac;

namespace CustomModel
{
    // Specify complex registrations in code
    public class CarTransportModule : Autofac.Module
    {
        public bool ObeySpeedLimit { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Car>().As<IVehicle>();

            if (ObeySpeedLimit)
                builder.RegisterType<SaneDriver>().As<IDriver>();
            else
                builder.RegisterType<CrazyDriver>().As<IDriver>();
        }
    }
}
