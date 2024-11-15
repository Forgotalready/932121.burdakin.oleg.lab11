using Microsoft.Extensions.FileProviders;
using WebApplication1.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<CalculationService>();

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