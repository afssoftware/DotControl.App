using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DotControl.CLibrary;
using DotControl.CLibrary.Interfaces;
using System.IO;
using Autofac;

namespace DotControl.UI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BetterAccount>().As<IAccount>();

            //builder.RegisterType<Application>().AsSelf()
            //    .As<IApplication>().InstancePerRequest();
            //builder.RegisterType<Account>().As<IAccount>();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(DotControl.CLibrary))) //projectname
            builder.RegisterAssemblyTypes(Assembly.Load("DotControl.CLibrary")) //projectname    
                .Where(t => t.Namespace.Contains("Interfaces"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
