using Netflix.WebU�.Extensions.HttpClient;
using Netflix.WebU�.Extensions.ServiceApiSetting;
using Netflix.WebU�.Services.CommentServices.CommentsServices;
using Netflix.WebU�.Services.ContentServices.EpisodeServices;
using Netflix.WebU�.Services.ContentServices.SeasonService;
using Netflix.WebU�.Services.ContentServices.SeriesServices;
using Netflix.WebU�.Services.MovieService.MoviesService;
using Netflix.WebU�.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddServiceApiSettings(builder.Configuration);

var values = builder.Configuration.GetSection("ServiceApiSettings").Get<ServiceApiSettings>();

builder.Services.AddCustomHttpClients(values);

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