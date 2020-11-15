using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace Acme.BookStore.Users
{
    /* 该实体共享同一个表/集合(默认为“AbpUsers”)
     *Identity模块的IdentityUser实体
     *可以定义自定义属性到这个类中
     *永远不要创建或删除这个实体，因为它是Identity模块的Job
     *可以用这个实体从数据库查询用户
     *可以更新自定义属性值
     */
    public class AppUser : FullAuditedAggregateRoot<Guid>, IUser
    {
        #region Base properties

        /* 这些属性与标识模块的IdentityUser实体共享
         * 不要通过该类改变这些属性
         * 相反，使用身份识别模块服务(如IdentityUserManager)来改变它们
         * 因此，该属性被设计为只读!
         */

        public virtual Guid? TenantId { get; private set; }

        public virtual string UserName { get; private set; }

        public virtual string Name { get; private set; }

        public virtual string Surname { get; private set; }

        public virtual string Email { get; private set; }

        public virtual bool EmailConfirmed { get; private set; }

        public virtual string PhoneNumber { get; private set; }

        public virtual bool PhoneNumberConfirmed { get; private set; }

        #endregion

        /* 添加自己的属性,比如:public string MyProperty { get; set; }
         * 如果添加了一个属性并使用了EF Core
         * 1. 更新BookStoreDbContext.OnModelCreating为新属性配置映射
         * 2. 更新BookStoreEfCoreEntityExtensionMappings以扩展IdentityUser实体并将新属性添加到迁移中
         * 3. 使用Add-Migration添加新的数据库迁移
         * 4. 运行.DbMigrator项目(或使用Update-Database命令)来应用数据库架构更改。
         */

        private AppUser()
        {
            
        }
    }
}
