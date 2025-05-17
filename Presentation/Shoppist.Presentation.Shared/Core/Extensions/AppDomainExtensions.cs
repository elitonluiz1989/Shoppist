using System.Reflection;

namespace Shoppist.Presentation.Shared.Core.Extensions;

public static class AppDomainExtensions
{
    public static IEnumerable<Assembly> GetAssembliesByNamespace(this AppDomain appDomain, string @namespace)
    {
        Assembly[] assemblies = appDomain.GetAssemblies();

        List<Assembly> matchingAssemblies = assemblies
            .Where(assembly =>
                assembly.GetTypes().Any(type => type.Namespace != null && type.Namespace.StartsWith(@namespace)))
            .ToList();

        return matchingAssemblies;
    }
}