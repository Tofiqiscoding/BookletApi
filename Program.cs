using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using BookletApi.Data;
using BookletApi.Models;
using BookletApi.Utils;

var builder = WebApplication.CreateBuilder(args);

// JWT config
var jwtKey = builder.Configuration["JWT:Key"] ?? Environment.GetEnvironmentVariable("JWT__KEY") ?? "change_this_secret";
var jwtIssuer = builder.Configuration["JWT:Issuer"] ?? Environment.GetEnvironmentVariable("JWT__ISSUER") ?? "booklet_api";
var jwtAudience = builder.Configuration["JWT:Audience"] ?? Environment.GetEnvironmentVariable("JWT__AUDIENCE") ?? "booklet_frontend";


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? 
                       Environment.GetEnvironmentVariable("CONNECTIONSTRING") ?? 
                       "Host=localhost;Database=booklet;Username=postgres;Password=tofiq077";

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString));


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtIssuer,
        ValidAudience = jwtAudience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
    };
});

builder.Services.AddAuthorization();
builder.Services.AddControllers();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

app.UseCors("AllowAll");
app.UseAuthentication();
app.UseAuthorization();

// Minimal API endpoints
app.MapGet("/", () => Results.Text("Booklet API running"));

// Auth endpoints
app.MapPost("/auth/register", async (AppDbContext db, RegisterRequest req) =>
{
    if (await db.Users.AnyAsync(u => u.Email == req.Email))
        return Results.BadRequest(new { error = "Email already exists" });

    SecurityHelpers.CreatePasswordHash(req.Password, out var hash, out var salt);
    var user = new User
    {
        Id = Guid.NewGuid(),
        Email = req.Email,
        PasswordHash = hash,
        PasswordSalt = salt,
        Role = req.Role ?? "admin"
    };
    db.Users.Add(user);
    await db.SaveChangesAsync();

    return Results.Ok(new { user.Id, user.Email, user.Role });
});

app.MapControllers(); // For [ApiController] routes
app.Run();
