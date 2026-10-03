// برای استفاده از Controller، IActionResult و امکانات مربوط به MVC
using Microsoft.AspNetCore.Mvc;

// برای دسترسی به BlogDbContext
using MyFirstApp.Data;

using MyFirstApp.Models;

// مشخص می‌کنیم این کلاس متعلق به namespace مربوط به Controllerهای برنامه است
namespace MyFirstApp.Controllers;


// ساختن Controller مربوط به Postها
// چون اسم کلاس PostsController است، در URL با /Posts شناخته می‌شود
public class PostsController : Controller
{
    // یک متغیر برای نگه داشتن BlogDbContext
    // readonly یعنی بعد از ساخته شدن Controller، خودِ _context دوباره عوض نمی‌شود
    private readonly BlogDbContext _context;


    // این سازنده‌ی PostsController است
    // ASP.NET Core خودش BlogDbContext را به اینجا می‌دهد
    public PostsController(BlogDbContext context)
    {
        // BlogDbContext که گرفتیم را داخل _context قرار می‌دهیم
        _context = context;
    }


    // این یک Action به نام Index است
    // وقتی /Posts را باز کنیم، به صورت پیش‌فرض همین Action اجرا می‌شود
    public IActionResult Index()
    {
        // از جدول Posts داخل دیتابیس، تمام پست‌ها را می‌گیریم
        // posts = Post.objects.all()
        var posts = _context.Posts.ToList();


        // اطلاعات posts را به View می‌فرستیم
        // ASP.NET طبق Convention می‌رود سراغ:
        // Views/Posts/Index.cshtml
        // return render(request, "posts/index.html", {"posts": posts})
        return View(posts);
    }
}