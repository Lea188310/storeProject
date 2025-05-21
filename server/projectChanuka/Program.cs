using AutoMapper;
using BL.classes;
using BL.services;
using DAL.classes;
using DAL.Models;
using DAL.services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//category
builder.Services.AddScoped<ICategoryDAL,CategoryDAL>();
builder.Services.AddScoped<ICategoryBL, CategoryBL>();
//game
builder.Services.AddScoped<IGameDAL, GameDAL>();
builder.Services.AddScoped<IGameBL, GameBL>();
//custemer
builder.Services.AddScoped<ICustemerDAL, CustemerDAL>();
builder.Services.AddScoped<ICustemerBL,CustemerBL>();
//shopping
builder.Services.AddScoped<IShoppingDAL, ShoppingDAL>();
builder.Services.AddScoped<IShoppingBL, ShoppingBL>();
//shopingDetail
builder.Services.AddScoped<IShoppingDetailDAL, ShoppingDetailDAL>();
builder.Services.AddScoped<IShoppingDetailBL,ShoppingDetailBL>();
//builder.Services.AddScoped<IShoppingDetailDAL,ShoppingDetailDAL>();


builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<LEALE_VAINER_P_2025Context>
(options => options.UseSqlServer("Data Source = kitotSrv\\sql; Initial Catalog = LEALE_VAINER_P_2025; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework"));
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseStaticFiles();
app.Run();
