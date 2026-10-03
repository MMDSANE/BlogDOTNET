// دسترسی به قابلیت‌های Entity Framework Core
using Microsoft.EntityFrameworkCore;
using MyFirstApp.Models;

// مشخص می‌کنیم این کلاس در فضای نام Data قرار دارد
namespace MyFirstApp.Data;

// DbContext پل ارتباطی بین برنامه و دیتابیس است
public class BlogDbContext : DbContext
{
    // سازنده کلاس
    // تنظیمات اتصال به دیتابیس از طریق options دریافت می‌شود
    public BlogDbContext(DbContextOptions<BlogDbContext> options)
        : base(options)
    {
    }
    // معرفی به دیتابیس
    public DbSet<Post> Posts { get; set; }
}