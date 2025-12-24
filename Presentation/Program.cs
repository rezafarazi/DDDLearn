using Application.Commands.CreateUser;
using Domain.Repositories;
using Infrastacture.Persistance.Repositories;
using Infrastacture.Persistance;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(CreateUserCommandHandler).Assembly));

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


app.UseExceptionHandler("/Home/Error");
app.UseHsts();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
