using Acme.BookStore.Enum.Books;
using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.PresentationModel.Books
{
    /// <summary>
    /// 添加图书信息请求模型
    /// </summary>
    public class CreateBookRequestModel
    {
        /// <summary>
        /// 图书名称
        /// </summary>
        [Required(ErrorMessage = "图书名称不能为空")]
        [StringLength(128)]
        public string Name { get; set; }

        /// <summary>
        /// 图书类型
        /// </summary>
        [Required(ErrorMessage = "请选择图书类型")]
        public BookType Type { get; set; } = BookType.Undefined;

        /// <summary>
        /// 出版日期
        /// </summary>
        [Required(ErrorMessage = "出版日期不能为空")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        /// <summary>
        /// 价格
        /// </summary>
        [Required(ErrorMessage = "请输入图书价格")]
        public float Price { get; set; }
    }
}
