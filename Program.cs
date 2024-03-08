using Microsoft.EntityFrameworkCore;
using CRUDMinimalAPI.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CRUDMinimalAPI.EndPoints;
using CRUDMinimalAPI.Service;
using CRUDMinimalAPI.Repository;
var builder = WebApplication.CreateBuilder(args : args);


builder.Services.AddCors(setupAction: options =>
{
    options.AddPolicy(name: "CORSPolicy",
        configurePolicy: builder =>
        {
            builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithOrigins(origins: new[] { "http://localhost:5173", "https://appname.azurestaticapps.net" });
        });
});
var connectionString = builder.Configuration.GetConnectionString("dbcs");
builder.Services.AddDbContext<StudentContext>(x=> x.UseSqlServer(connectionString));
builder.Services.AddScoped<IStudentContract, StudentService>();
builder.Services.AddScoped<IStudentRepo, StudentRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policyName:"CORSPolicy");

//Get all employee
app.ConfigureStudentEndPoints();
app.Run();

