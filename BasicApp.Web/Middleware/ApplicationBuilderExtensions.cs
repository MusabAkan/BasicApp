using Microsoft.Extensions.FileProviders;

namespace BasicApp.Web.Middleware
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, string root)
        {
            const string nodeModules = "node_modules";
            var path = Path.Combine(root, nodeModules);
            var provider = new PhysicalFileProvider(path);
            var options = new StaticFileOptions
            {
                RequestPath = "/" + nodeModules,
                FileProvider = provider
            };
            app.UseStaticFiles(options);
            return app;
        }
    }
}
