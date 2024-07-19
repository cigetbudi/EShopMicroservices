var builder = WebApplication.CreateBuilder(args);

// DI services
builder.Services.AddCarter();
builder.Services.AddMediatR(config => {
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

// hhtp req pipelines
app.MapCarter();

app.Run();
