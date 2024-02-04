using MyCompany.MyProduct.Application;
using MyCompany.MyProduct.Infrastructure;
using MyCompany.MyProduct.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddPersistence(builder.Configuration);

#if(UseSwagger)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endif

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    #if(UseSwagger)
    app.UseSwagger();
    app.UseSwaggerUI();
    #endif
}

app.UseHttpsRedirection();

app.Run();
