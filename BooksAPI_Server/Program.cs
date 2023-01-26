using BooksAPI_Server.Data;
using BooksAPI_Server.Repositories;
using BooksAPI_Server.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddMvc().AddNewtonsoftJson();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient(); //Similar to axios client
builder.Services.AddScoped<OpenLibraryService>();
builder.Services.AddScoped<ToReadRepository>();
builder.Services.AddScoped<AuthorRepository>();
builder.Services.AddScoped<ToReadAuthorRepository>();
builder.Services.AddScoped<FavoritesRepository>();
builder.Services.AddScoped<FavoriteAuthorRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
