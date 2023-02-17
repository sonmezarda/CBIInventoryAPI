using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.FireBase;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IProductDal, EfProductDal>();
builder.Services.AddSingleton<IProductService, ProductManager>();

builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();

builder.Services.AddSingleton<IProductDetailDal, FBProductDetailDal>();
builder.Services.AddSingleton<IProductDetailService, ProductDetailManager>();

builder.Services.AddSingleton<IProductCommentDal, EFProductCommentDal>();
builder.Services.AddSingleton<ICommentService, CommentManager>();

builder.Services.AddSingleton<IBoxService, BoxManager>();
builder.Services.AddSingleton<IBoxDal, EfBoxDal>();

builder.Services.AddSingleton<ISpecListService, SpecListManager>();
builder.Services.AddSingleton<ISpecListDal, EfSpecListDal>();



builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("http://localhost:3000")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

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

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
