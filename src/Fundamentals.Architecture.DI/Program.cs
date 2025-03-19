using Fundamentals.Architecture.DI.Interfaces;
using Fundamentals.Architecture.DI.Models;
using Fundamentals.Architecture.DI.Repositories;
using Fundamentals.Architecture.DI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

#region LifeCycle
builder.Services.AddTransient<IOPerationTransient, Operation>();
builder.Services.AddScoped<IOperationScoped, Operation>();
builder.Services.AddSingleton<IOperationSingleton, Operation>();
builder.Services.AddSingleton<IOPerationSingletonInstance>(new Operation(Guid.Empty));
builder.Services.AddTransient<OperationService>();
#endregion

#region Real Life

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IClientService, ClientService>();

#endregion

#region Generics
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
#endregion

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
