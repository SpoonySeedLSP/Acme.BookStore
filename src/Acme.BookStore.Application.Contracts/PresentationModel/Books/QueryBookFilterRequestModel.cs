using Acme.BookStore.Enum.Books;
using Materal.Model;
using System;

namespace Acme.BookStore.PresentationModel.Books
{
    /// <summary>
    /// 查询图书请求模型
    /// </summary>
    public class QueryBookFilterRequestModel: PageRequestModel
    {
        /// <summary>
        /// 图书名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 图书类型
        /// </summary>
        public BookType? Type { get; set; }

        /// <summary>
        /// 出版日期-开始
        /// </summary>
        public DateTime? PublishDateStart { get; set; }

        /// <summary>
        /// 出版日期-结束
        /// </summary>
        public DateTime? PublishDateEnd { get; set; }

        /// <summary>
        /// 价格-最小值
        /// </summary>
        public float? MinPrice { get; set; }

        /// <summary>
        /// 价格-最大值
        /// </summary>
        public float? MaxPrice { get; set; }
    }
}
