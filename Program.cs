using UserManagementAPI.Data;
using UserManagementAPI.Routes;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<PersonContext>();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
        options.SwaggerEndpoint("/openapi/v1.json", "UserManagementAPI"));
    
}

app.PersonRoutes();

app.UseHttpsRedirection(); 
app.Run();
