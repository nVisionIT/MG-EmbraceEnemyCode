
namespace PayrollSystem.Interfaces.Injection
{
    public interface IDependencyInjector
    {
        T ResolveInstance<T>();
        T ResolveInstanceByName<T>(string name);
        T TryResolveInstance<T>();
        T TryResolveInstanceByName<T>(string name);
    }
}
