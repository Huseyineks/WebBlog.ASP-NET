using FluentValidation;
using Microsoft.EntityFrameworkCore;
using WebBlog.BusinessLogicLayer.Concrete;
using WebBlog.BusinessLogicLayer.Interface;
using WebBlog.DataAccesLayer.Data;
using WebBlog.Entitiy.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IValidator<RegisterationPost>, AppUserValidator>();

builder.Services.AddScoped<IAppUser, AppUserRepository>();

builder.Services.AddScoped<IArticle, ArticleRepository>();

builder.Services.AddScoped<IComment, CommentRepository>();


builder.Services.AddControllersWithViews();


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
