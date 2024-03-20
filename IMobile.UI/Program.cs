using IMobile.Business.DependencyResolver.DependencyRegister;
using IMobile.Core.Entities.Concrete;
using IMobile.DataAccess.Concrete.EntityFramework;
using IMobile.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDefaultIdentity<AppUser>().AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();


// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.Create();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoint =>
{
    endpoint.MapControllerRoute(
         name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}/{seourl?}"
       );
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{seourl?}"
    );

app.Run();
