using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.Utils
{
    public class DIRoot
    {
        private static IKernel _kernel;

        public static void Wire(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
           
        }
        public static void Bind(INinjectModule module)
        {
            _kernel.Load(module);
        }
        public static T Resolve<T>() => _kernel.Get<T>();
    }
}
