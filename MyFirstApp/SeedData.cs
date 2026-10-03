using MyFirstApp.Data;
using MyFirstApp.Models;

public static class SeedData
{
    public static void Initialize(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<BlogDbContext>();

        if (context.Posts.Any())
        {
            return;
        }

        context.Posts.AddRange(
            new Post
            {
                Title = "اولین پست من",
                Content = "این اولین پست من در ASP.NET Core است."
            },
            new Post
            {
                Title = "یادگیری ASP.NET Core",
                Content = "دارم ASP.NET Core و Entity Framework Core را یاد می‌گیرم."
            },
            new Post
            {
                Title = "کار با PostgreSQL",
                Content = "این پست از طریق Seed وارد دیتابیس شده است."
            }
        );

        context.SaveChanges();
    }
}