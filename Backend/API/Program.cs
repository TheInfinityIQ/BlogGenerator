using EasyVue3API;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "MyFrontEnd";

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:3000", "https://localhost:3000").AllowAnyMethod().AllowAnyHeader();
                      });
});

builder.Services.AddSingleton<DataRepository>(container =>
{
    var db = new DataRepository();
    db.AddBlogs(5);
    return db;
});

var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);

app.MapGet("/blog", ([FromServices] DataRepository db) =>
{
    if (db.Blogs == null)
    {
        return Results.NotFound();
    }

    BlogsResponse br = new BlogsResponse(db.Blogs);

    return Results.Ok(br);
}); 

app.MapGet("/blog/{id}", ([FromServices] DataRepository db, [FromRoute] int id) =>
{
    Blog? blog = db.Blogs.FirstOrDefault(blog => blog.Id == id);

    if (blog == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(blog);
});

app.MapPut("/blog/{id}", ([FromServices] DataRepository db, [FromRoute] int id, [FromBody] Blog blog) =>
{
    Blog? blogToEdit = db.Blogs.FirstOrDefault(blog => blog.Id == id);

    if (blogToEdit == null)
    {
        return Results.NotFound();
    }

    int i = db.Blogs.IndexOf(blogToEdit);
    db.Blogs[i] = blog;

    return Results.Ok("Blog Updated");
});

app.MapPost("/blog", ([FromServices] DataRepository db, [FromBody] Blog blog) =>
{
    //Id passed from UI will not be valid. Needing to create new blog to get generated ID
    Blog toAdd = new Blog(blog.Title, blog.Content);
    db.Blogs.Add(toAdd);

    return Results.Created("https://localhost:7240/blog/{toAdd.Id}", toAdd);
});

app.MapDelete("/blog/{id}", ([FromServices] DataRepository db, [FromRoute] int id) =>
{
    Blog? blogToDelete = db.Blogs.FirstOrDefault(blog => blog.Id == id);

    if (blogToDelete == null)
    {
        return Results.NotFound();
    }

    db.Blogs.Remove(blogToDelete);
    return Results.Ok();
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.Run();
