using DemoInyeccionDependencias.Strategies.BlobStorage;
using DemoInyeccionDependencias.Strategies.BlobStorageExtended;
using DemoInyeccionDependencias.Strategies.Bulder;
using DemoInyeccionDependencias.Strategies.Factory;
using DemoInyeccionDependencias.Strategies.Lazy;
using DemoInyeccionDependencias.Strategies.Reflection;
using DemoInyeccionDependencias.Strategies.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddTransient<GuidService>();
//builder.Services.AddScoped<GuidService>();
builder.Services.AddSingleton<GuidService>();



builder.Services.AddScoped<IPersonService, TeacherService>();
builder.Services.AddScoped<IPersonService, PoliceService>();
builder.Services.AddScoped<IPersonService, DoctorService>();

builder.Services.AddBlobStorage(builder.Configuration);
builder.Services.AddBlobStorageExtended(builder.Configuration);

builder.Services.RegisterServicesRefactor();

builder.Services.AddBotServiceLazier();




builder.Services.AddTransportFactory()
            .AddTransport<Truck>(TransportType.Road)
            .AddTransport<Ship>(TransportType.Sea);






var app = builder.Build();


var scope = app.Services.CreateScope();

var guidService = scope.ServiceProvider.GetRequiredService<GuidService>();
var guidService2 = scope.ServiceProvider.GetRequiredService<GuidService>();


var scope2 = app.Services.CreateScope();

var guidService3 = scope2.ServiceProvider.GetRequiredService<GuidService>();
var guidService4 = scope2.ServiceProvider.GetRequiredService<GuidService>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
