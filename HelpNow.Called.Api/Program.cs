using FluentValidation.AspNetCore;
using FluentValidation;
using HelpNow.Called.Domain.Dtos;
using HelpNow.Called.Application.RegisterService;
using HelpNow.Called.Infrastructure.RegisterRepository;
var builder = WebApplication.CreateBuilder(args);

// Injeção de dependências
builder.Services.AddServices();
builder.Services.AddRepositories(builder.Configuration);

// MVC Controllers
builder.Services.AddControllers();

// FluentValidation
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<CalledRegisterDtoValidator>();

// Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();