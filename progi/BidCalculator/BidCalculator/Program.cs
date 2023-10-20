using BidCalculation.Services.Facade;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICalculate, CalculateFacade>();
//builder.Services.AddSwaggerGen();


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

/*if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI(c =>
    {
        app.UseSwagger();
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
    });
}*/

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
