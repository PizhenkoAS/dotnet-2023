using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PharmacyCityNetwork;
using PharmacyCityNetwork.Server;
using PharmacyCityNetwork.Server.Repository;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<PharmacyCityNetworkDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("PharmacyCityNetwork")!)
);
var mapperConfig = new MapperConfiguration(config => config.AddProfile(new MappingProfile()));
var mapper = mapperConfig.CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddSingleton<IPharmacyCityNetworkRepository, PharmacyCityNetworkRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFileName));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
