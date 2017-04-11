using LPLSystems.Services;
using Microsoft.Practices.Unity;

namespace LPLSystems
{
    public static class ContainerHelper
    {
        private static IUnityContainer _container;
        static ContainerHelper()
        {
            _container = new UnityContainer();
            _container.RegisterType<IEmployeeRepository, EmployeeRespository>(new ContainerControlledLifetimeManager());
        }

        public static IUnityContainer Container
        {
            get { return _container; }
        }
    }
}
