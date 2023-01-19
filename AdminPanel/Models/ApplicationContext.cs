﻿using AdminPanel.Models.PicturesModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Models
{
    //унаследуем наш ApplicationContext от DbCOntext (через знак " : ")
    public class ApplicationContext: IdentityDbContext<User>
    {
        //в БД появится таблица Users после миграции.
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<News> News { get; set; } = null!;
        public DbSet<NewsPictures> NewsPictures { get; set; } 
        public DbSet<AchievementsPictures> AchievementsPictures { get; set; } 
        public DbSet<Teachers> Teachers { get; set; } 
        public DbSet<Achievements> Achievements { get; set; } 
        public DbSet<Managers> Managers { get; set; } 
        public DbSet<Partners> Partners { get; set; } 
        public DbSet<Calendar> Calendars { get; set; } 
        public DbSet<Events> Events { get; set; } 


        //созаем конструктор ApplicationContext, чтоб можно было инициализировать объекты класса AppliCationContext в других
        //классах (контроллеры  втом числе)

        //DbContextOptions служит для установки подключения БД через options,
        //в нашем случае по умолчанию нет никакх значений
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }
    }
}
