using AraBul.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//persistence katman�ndaki extension �a�r�labiliyor. katmanlardaki kullan�m�n ayr��t�r�lmas� sa�lan�yor.
builder.Services.AddPersistenceServices();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
