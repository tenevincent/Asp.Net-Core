using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismDryIocMediatR
{
    public static class ContainerExtensions
    {
        public static bool IsMediatorHandler(this Type arg)
        {
            //Ugly hack to limit assembly registration to request handlers only
            return arg.GetInterfaces().Where(i => i.Name.StartsWith("IRequestHandler")).Any();
        }
    }
}
