using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var myCorsPolicy = "MyCorsPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name : myCorsPolicy,
        builder =>
        {
            builder.AllowAnyOrigin();
        });
});

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers().AddJsonOptions(options => 
{ 
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});



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

app.UseCors(myCorsPolicy);

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
