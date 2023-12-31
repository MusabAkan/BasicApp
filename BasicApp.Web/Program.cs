using BasicApp.Bussiness.Abstract;
using BasicApp.Bussiness.Concrete;
using BasicApp.DataAccess.Abstract;
using BasicApp.DataAccess.Concrete.EntityFramework;
using BasicApp.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddSingleton<ICartSessionService, CartSesisonService>();
builder.Services.AddSingleton<ICartService, CartManager>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddMvc();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles(); 
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
