using BloggingApp.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add necessary services to use controllers.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// Add necessary services to use API endpoints
builder.Services.AddEndpointsApiExplorer();

// Add necessary services to generate Swagger/OpenAPI documentation to test apis
builder.Services.AddSwaggerGen();

// Inject AddDbContext dependency
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BloggingAppConnectionString"));
});

//Build app with all added services and configurations
var app = builder.Build();

// Configure the HTTP request pipeline.

// Check if app runs at the development stage
if (app.Environment.IsDevelopment())
{
    // Use Swagger middleware
    app.UseSwagger();
    // Use Swagger UI middleware
    app.UseSwaggerUI();
}

// Middleware to redirect HTTP requests to HTTPS requests
app.UseHttpsRedirection();

// Middleware to check user authentication before accessing to provided resources
app.UseAuthorization();

// middleware to map requests to actions defined in controllers
app.MapControllers();

// Run application
app.Run();
