using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Acme.BookStore
{
    [DependsOn(
     typeof(AbpHttpClientModule), //用来创建客户端代理
     typeof(BookStoreApplicationContractsModule) //包含应用服务接口
     )]
    public class MyClientAppModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //创建动态客户端代理
            //AddHttpClientproxies方法获得一个程序集,找到这个程序集中所有的服务接口,创建并注册代理类
            context.Services.AddHttpClientProxies(
                typeof(BookStoreApplicationContractsModule).Assembly
            );

            #region 配置

            /* AbpRemoteServiceOptions
             * 默认情况下AbpRemoteServiceOptions从appsettings.json获取
             * 或者,可以使用Configure方法来设置或重写它,如:
             */
            context.Services.Configure<AbpRemoteServiceOptions>(options =>
            {
                options.RemoteServices.Default =
                    new RemoteServiceConfiguration("http://localhost:53929/");
            });

            /*多个远程服务端点
             *AddHttpClientProxies方法有一个可选的参数来定义远程服务的名字:
             *remoteServiceConfigurationName参数会匹配通过AbpRemoteServiceOptions配置的服务端点,
             *如果BookStore端点没有定义就会使用默认的Default端点*/
            context.Services.AddHttpClientProxies(typeof(BookStoreApplicationContractsModule).Assembly, remoteServiceConfigurationName: "BookStore");

            /* 作为默认服务
             * 当你为IBookAppService创建了一个服务代理,
             * 你可以直接注入IBookAppService来使用代理客户端
             * 你可以传递asDefaultService:false到AddHttpClientProxies方法来禁用此功能
             * 如果你禁用了asDefaultService,你只能使用IHttpClientProxy<T>接口去使用客户端代理
             */
            context.Services.AddHttpClientProxies(typeof(BookStoreApplicationContractsModule).Assembly,asDefaultServices: false);

            #endregion

        }
    }
}
