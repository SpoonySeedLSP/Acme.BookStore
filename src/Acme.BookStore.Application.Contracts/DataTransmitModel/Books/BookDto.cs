using Acme.BookStore.Enum.Books;
using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.DataTransmitModel.Books
{
    /// <summary>
    /// 图书数据传输模型
    /// </summary>
    public class BookDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// 图书名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 图书类型
        /// </summary>
        public BookType Type { get; set; }

        /// <summary>
        /// 出版日期
        /// </summary>
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public float Price { get; set; }
    }
}
