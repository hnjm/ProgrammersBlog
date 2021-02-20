using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id); //primary key
            builder.Property(a => a.Id).ValueGeneratedOnAdd();//bir bir artıyor anlamına geliyor
            builder.Property(a => a.Title).HasMaxLength(100);//maks uzunluk
            builder.Property(a => a.Title).IsRequired();//zorunlu
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");//bu içeirk nvarchar alacak ve sınırsız karakter alıyor
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewsCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a=>a.CategoryId);
            //bu bir bire çok ilişki,article bir tane category alabilir, bir kategorinin birden çok makalesi olabilir, foreignkey olarakta categoryID
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            //bu da bire çok ilişki
            builder.ToTable("Articles");
            builder.HasData(new Article
            {
                Id = 1,
                CategoryId = 1,
                Title = "C# 9.0 ve NET5 Yenilikleri",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
                " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris" +
                " nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in" +
                " reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia" +
                " deserunt mollit anim id est laborum.",
                Thumbnail = "Default.jpg",
                SeoDesription = "C# 9.0 ve NET5 Yenilikleri",
                SeoTags = "C#, C# 9, NET5, NET Framework, .NET Core",
                SeoAuthor = "Yunus Özdemir",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# 9.0 ve NET5 Yenilikleri",
                UserId = 1,
                ViewsCount = 317,
                CommentCount = 1,
            },
            new Article
            {
                Id = 2,
                CategoryId = 2,
                Title = "C++ 11 ve 19 Yenilikleri",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
                " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris" +
                " nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in" +
                " reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia" +
                " deserunt mollit anim id est laborum.",
                Thumbnail = "Default.jpg",
                SeoDesription = "C++ 11 ve 19 Yenilikleri",
                SeoTags = "C++ 11 ve 19 Yenilikleri",
                SeoAuthor = "Yunus Özdemir",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C++ 11 ve 19 Yenilikleri",
                UserId = 1,
                ViewsCount = 214,
                CommentCount = 1,
            },
             new Article
             {
                 Id = 3,
                 CategoryId = 3,
                 Title = "JavaScript ES2019 ve ES2020 Yenilikleri",
                 Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
                " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris" +
                " nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in" +
                " reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia" +
                " deserunt mollit anim id est laborum.",
                 Thumbnail = "Default.jpg",
                 SeoDesription = "JavaScript ES2019 ve ES2020 Yeniliklerii",
                 SeoTags = "JavaScript ES2019 ve ES2020 Yenilikleri",
                 SeoAuthor = "Yunus Özdemir",
                 Date = DateTime.Now,
                 IsActive = true,
                 IsDeleted = false,
                 CreatedByName = "InitialCreate",
                 CreatedDate = DateTime.Now,
                 ModifiedByName = "InitialCreate",
                 ModifiedDate = DateTime.Now,
                 Note = "JavaScript ES2019 ve ES2020 Yenilikleri",
                 UserId = 1,
                 ViewsCount=100,
                 CommentCount=1,
             });

        }
    }
}
