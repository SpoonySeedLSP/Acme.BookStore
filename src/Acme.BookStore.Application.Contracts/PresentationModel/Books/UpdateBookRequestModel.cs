using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.PresentationModel.Books
{
    /// <summary>
    /// 修改图书信息请求模型
    /// </summary>
    public class UpdateBookRequestModel: CreateBookRequestModel
    {
        /// <summary>
        /// 图书唯一标书
        /// </summary>
        [Required(ErrorMessage = "图书唯一标书不能为空")]
        public Guid Id { get; set; }
    }
}
