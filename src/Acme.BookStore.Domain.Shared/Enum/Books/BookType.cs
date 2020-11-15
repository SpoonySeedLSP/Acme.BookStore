using System.ComponentModel;

namespace Acme.BookStore.Enum.Books
{
    /// <summary>
    /// 书籍类型枚举
    /// </summary>
    public enum BookType:byte
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Undefined = 0,

        /// <summary>
        /// 冒险
        /// </summary>
        [Description("冒险")]
        Adventure=1,

        /// <summary>
        /// 传记
        /// </summary>
        [Description("传记")]
        Biography=2,

        /// <summary>
        /// 现实主义
        /// </summary>
        [Description("现实主义")]
        Dystopia=3,

        /// <summary>
        /// 理想主义
        /// </summary>
        [Description("理想主义")]
        Fantastic=4,

        /// <summary>
        /// 恐怖/惊悚
        /// </summary>
        [Description("恐怖/惊悚")]
        Horror=5,

        /// <summary>
        /// 科学
        /// </summary>
        [Description("科学")]
        Science=6,

        /// <summary>
        /// 科幻小说
        /// </summary>
        [Description("科幻小说")]
        ScienceFiction=7,

        /// <summary>
        /// 诗歌
        /// </summary>
        [Description("诗歌")]
        Poetry=8
    }
}
