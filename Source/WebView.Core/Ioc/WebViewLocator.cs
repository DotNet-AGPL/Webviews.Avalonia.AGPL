namespace WebViewCore.Ioc;

using System;
using Microsoft.Extensions.DependencyInjection;

public static class WebViewLocator
{
    private static readonly Lazy<IServiceCollection> _serviceCollectionLazy = new(() => new ServiceCollection());

    private static readonly Lazy<IServiceProvider> _serviceProviderLazy = new(() =>
    {
        return _serviceCollectionLazy.Value.BuildServiceProvider(new ServiceProviderOptions { ValidateOnBuild = true, ValidateScopes = true });
    });

    public static IServiceCollection s_Registrator
    {
        get
        {
            if (_serviceProviderLazy.IsValueCreated)
            {
                throw new InvalidOperationException("IServiceProvider have created");
            }

            return _serviceCollectionLazy.Value;
        }
    }

    public static IServiceProvider s_ResolverContext => _serviceProviderLazy.Value;

    public static IServiceCollection RegisterSingleton<TService>(this IServiceCollection regitser) where TService : class
    {
        return regitser.AddSingleton<TService>();
    }

    public static IServiceCollection RegisterInstance<TService>(this IServiceCollection regitser, TService service) where TService : class
    {
        return regitser.AddSingleton<TService>(service);
    }

    public static IServiceCollection RegisterSingleton<TService>(this IServiceCollection regitser, Func<TService> func) where TService : class
    {
        return regitser.AddSingleton<TService>(m => func.Invoke());
    }

    public static IServiceCollection RegisterSingleton<TService, TImplementation>(this IServiceCollection regitser) where TService : class where TImplementation : class, TService
    {
        return regitser.AddSingleton<TService, TImplementation>();
    }

    public static TService GetIocService<TService>(this IServiceProvider regitser) where TService : class
    {
        var service = regitser.GetService<TService>();
#pragma warning disable CS8603
        return service;
#pragma warning restore CS8603
    }
}

/*
using DryIoc;
using DryIoc.Shared.Extensions;
public class WebViewLocator1
{
    static WebViewLocator1()
    {
        __dryIocContainer = new Lazy<Container>(() => new Container(RulesExtensions.DefaultRules));
    }

    readonly static Lazy<Container> __dryIocContainer;

    public static IRegistrator s_Registrator => __dryIocContainer.Value;
    public static IResolverContext s_ResolverContext => __dryIocContainer.Value;
}
*/
