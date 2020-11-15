using Acme.BookStore.Model.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.BookStore.ModelConfig.Books
{
    /// <summary>
    /// 图书模型配置
    /// </summary>
    internal sealed class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.CreatorId)
                .IsRequired(false);
            builder.Property(e => e.CreationTime)
                .IsRequired();
            builder.Property(e => e.LastModificationTime)
                .IsRequired(false);
            builder.Property(e => e.LastModifierId)
                .IsRequired(false);
            builder.Property(e => e.Name)//图书名称
                .IsRequired()
                .HasMaxLength(BookStoreConsts.MaxNameLength);
            builder.Property(e => e.Type)//图书类型
                .IsRequired(false)
                .HasColumnType("tinyint");
            builder.Property(e => e.PublishDate)//出版日期
                .IsRequired();
            builder.Property(e => e.Price)//价格
                .IsRequired()
                .HasDefaultValue(0.00);
        }
    }
}
