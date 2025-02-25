using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicWebApp.Models;
using System;
using System.Linq;

namespace MusicWebApp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Nếu đã có dữ liệu, không cần seed nữa
                if (context.Users.Any()) return;

                // Seed Users
                context.Users.AddRange(
                    new User
                    {
                        Username = "admin",
                        Email = "admin@musicweb.com",
                        Password = "admin123", // Mật khẩu tạm thời, cần hash nếu muốn bảo mật
                        Role = "Admin",
                        CreatedAt = DateTime.Now
                    },
                    new User
                    {
                        Username = "uploader1",
                        Email = "uploader1@musicweb.com",
                        Password = "uploader123",
                        Role = "Uploader",
                        CreatedAt = DateTime.Now
                    },
                    new User
                    {
                        Username = "listener1",
                        Email = "listener1@musicweb.com",
                        Password = "listener123",
                        Role = "Listener",
                        CreatedAt = DateTime.Now
                    }
                );

                // Lưu thay đổi vào database
                context.SaveChanges();
            }
        }
    }
}
