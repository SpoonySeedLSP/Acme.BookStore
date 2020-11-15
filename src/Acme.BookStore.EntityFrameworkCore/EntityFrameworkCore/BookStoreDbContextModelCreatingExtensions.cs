using Acme.BookStore.Model.Books;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.BookStore.EntityFrameworkCore
{
    public static class BookStoreDbContextModelCreatingExtensions
    {
        public static void ConfigureBookStore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* 在这里配置自己的表/实体 */

            ////添加Book实体的映射
            //builder.Entity<Book>(b =>
            //{
            //    b.ToTable(BookStoreConsts.DbTablePrefix + "Book",
            //        BookStoreConsts.DbSchema);
            //    b.ConfigureByConvention();//自动配置/映射基类
            //    b.Property(x => x.Name).IsRequired().HasMaxLength(BookStoreConsts.MaxNameLength);
            //});

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BookStoreConsts.DbTablePrefix + "YourEntities", BookStoreConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}