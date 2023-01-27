using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MusicStore.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
// Add Our Custom Services For Handling Users, The Basket, All Products and Artists
builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<BasketService>();
builder.Services.AddSingleton<ProductService>();
builder.Services.AddSingleton<ArtistService>();

var app = builder.Build();

// Static Function Attempting To Seed The Database
Database.TrySeedDatabase();

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
