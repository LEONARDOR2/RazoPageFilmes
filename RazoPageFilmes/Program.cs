using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazoPageFilmes.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazoPageFilmesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazoPageFilmesContext") ?? throw new InvalidOperationException("Connection string 'RazoPageFilmesContext' not found.")));

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
