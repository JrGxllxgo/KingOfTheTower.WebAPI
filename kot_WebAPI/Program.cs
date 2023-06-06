using BusinessLogic.Team;
using BusinessLogic.User;
using BusinessLogic.Player;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Dependencies

builder.Services.AddScoped<IUserBll, UserBLL>();
builder.Services.AddScoped<ITeamBll, TeamBLL>();
builder.Services.AddScoped<IPlayerBll, PlayerBLL>();

#endregion


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
