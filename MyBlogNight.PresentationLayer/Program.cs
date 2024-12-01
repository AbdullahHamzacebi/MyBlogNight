using FluentValidation.AspNetCore;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.BusinessLayer.Concrete;
using MyBlogNight.BusinessLayer.Container.Container;
using MyBlogNight.DataAccessLayer.Abstarct;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.EntityFramework;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.PresentationLayer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//DbContext'den sadece devam etmek istiyorum dersen a�a��daki
builder.Services.AddDbContext<BlogContext>();


//Identity kullanmak istiyorsak a�a��daki yazd���m�z olmal�. EN son olarak da error k�sm�n� ekledik.
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<BlogContext>().AddErrorDescriber<CustomIdentityErrorValidator>();

builder.Services.ContainerDependencies();

builder.Services.AddControllersWithViews().AddFluentValidation();

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
app.UseAuthentication();  // Bu sayfaya sadece adminler eri�sin anlam�nda.
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.Run();
