using Microsoft.EntityFrameworkCore;
using School.Infrastructure.Context;
using School.Infrastructure.Interfaces;
using School.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// 1. Agregar servicios al contenedor.
builder.Services.AddControllers();

// 2. Configurar el DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlServer(connectionString));

// 3. Registrar los Repositorios
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

// 4. Configurar Swagger (OpenAPI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // Puedes borrar esta línea si no usas HTTPS

app.UseAuthorization();

app.MapControllers();

app.Run();