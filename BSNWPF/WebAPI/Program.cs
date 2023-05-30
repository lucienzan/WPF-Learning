using BSNWPF.Back.DataAccess;
using BSNWPF.CommonLibrary;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

APISetting.Configuration = app.Configuration;
CommonSetting.BSNConnectionString = iConvert.ToString(app.Configuration.GetValue(typeof(string), APISetting.KEY_CONNECTSTR)) ;
CommonSetting.PackageConnectionString = iConvert.ToString(app.Configuration.GetValue(typeof(string), APISetting.KEY_CONNECTSTR_PACKAGE));
CommonSetting.LogOutPutDirectory = iConvert.ToString(app.Configuration.GetValue(typeof(string),APISetting.KEY_LOGDIRECTORY));
CommonSetting.Log = new iLog(180, CommonSetting.LogOutPutDirectory);
app.UseAuthorization();

app.MapControllers();

app.Run();
