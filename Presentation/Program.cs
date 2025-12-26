using Application.Commands.CreateUser;
using Domain.Repositories;
using Infrastacture.Persistance.Repositories;
using Infrastacture.Persistance;
using Application.Commands.UpdateUser;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Application.Quaries.GetAllUsers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


//CQRS Handler
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(CreateUserCommandHandler).Assembly));

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(UpdateUserCommandHandler).Assembly));

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(GetUserByIdQuaryHandler).Assembly));


//connection string database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Data Source=localhost;Initial Catalog=LearnDB;Integrated Security=True;Encrypt=False")));



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
