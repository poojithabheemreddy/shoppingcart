using Microsoft.Extensions.FileProviders;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<shoppingapplication.Services.ILoginService, shoppingapplication.Services.LoginService>();
builder.Services.AddScoped<shoppingapplication.Repositories.ILoginRepository, shoppingapplication.Repositories.LoginRepository>();
builder.Services.AddScoped<shoppingapplication.Services.IRegisterService, shoppingapplication.Services.RegisterService>();
builder.Services.AddScoped<shoppingapplication.Repositories.IRegisterRepository, shoppingapplication.Repositories.RegisterRepository>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseCors(options =>options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UsePathBase("/shoppingapplication");
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "mystaticfiles")),
    RequestPath = "/mystaticfiles"
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=login}/{action=Index}/{id?}");

app.Run();
