using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(new StaticFileOptions
{
        FileProvider = new PhysicalFileProvider(
                Path.Combine(builder.Environment.ContentRootPath, "Content")),
        RequestPath = "/Content"
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/"
);

app.MapControllerRoute(
    name: "Calculation",
    pattern: "{controller}/{action}/"
);

app.Run();