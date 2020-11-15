using Microsoft.EntityFrameworkCore;
using Acme.BookStore.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
using Acme.BookStore.Model.Books;

namespace Acme.BookStore.EntityFrameworkCore
{
    /* 运行时使用的实际DbContext,只包括实体,不包含所使用模块的实体，因为每个模块已经包含了实体自己的DbContext类
     * 如果希望与使用的模块共享一些数据库表，只需创建一个类似于为AppUser所做的结构
     *不要使用这个DbContext进行数据库迁移，因为它不包含使用的模块。有关迁移，请参阅BookStoreMigrationsDbContext。
     */
    [ConnectionStringName("Default")]
    public class BookStoreDbContext : AbpDbContext<BookStoreDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        /* 在这里为聚合根/实体添加DbSet属性
         * 再映射到BookStoreDbContextModelCreatingExtensions.ConfigureBookStore
         */

        #region 书籍

        /// <summary>
        ///添加DbSet属性,将Book实体和DbContext建立关联
        /// </summary>
        public DbSet<Book> Book { get; set; }

        #endregion

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /*在这里配置共享表(包含模块)*/

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //与IdentityUser共享同一个表“AbpUsers”

                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* 为附加属性配置映射
                 * 也可以查看BookStoreEfCoreEntityExtensionMappings类
                 */
            });

            /* 在ConfigureBookStore方法中配置自己的表/实体 */

            builder.ConfigureBookStore();
        }
    }
}
