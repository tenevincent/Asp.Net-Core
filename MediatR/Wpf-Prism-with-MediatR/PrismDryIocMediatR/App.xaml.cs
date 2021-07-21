using DryIoc;
using MediatR;
using MediatR.Pipeline;
using Prism.DryIoc;
using Prism.Ioc;
using PrismDryIocMediatR.Views;
using System.Linq;
using System.Windows;




namespace PrismDryIocMediatR
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        { 
            var container = containerRegistry.GetContainer();
            container.RegisterDelegate<ServiceFactory>(r => r.Resolve);
            container.RegisterMany(new[] { typeof(IMediator).GetAssembly() }, Registrator.Interfaces);
            container.RegisterMany(typeof(App).GetAssembly().GetTypes().Where(t => t.IsMediatorHandler()));

            container.Register(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>), ifAlreadyRegistered: IfAlreadyRegistered.AppendNewImplementation);
            container.Register(typeof(IPipelineBehavior<,>), typeof(RequestPostProcessorBehavior<,>), ifAlreadyRegistered: IfAlreadyRegistered.AppendNewImplementation);

            // more view registrations here


        
        }
    }
}
