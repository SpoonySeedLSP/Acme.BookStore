using Acme.BookStore.DataTransmitModel.Books;
using Acme.BookStore.Model.Books;
using Acme.BookStore.PresentationModel.Books;
using AutoMapper;

namespace Acme.BookStore.AutoMapperProfile
{
    /// <summary>
    /// 书籍AutoMapper配置
    /// </summary>
    public sealed class BookProfile : Profile
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public BookProfile()
        {
            //图书Domain转图书数据传输模型
            CreateMap<Book, BookDto>();

            //添加信息请求模型转图书Domain
            CreateMap<CreateBookRequestModel, Book>();
            //修改信息请求模型转图书Domain
            CreateMap<CreateBookRequestModel, Book>()
                .ForMember(m => m.Id, n => n.Ignore())
                .ForMember(m => m.CreationTime, n => n.Ignore())
                .ForMember(m => m.CreatorId, n => n.Ignore());
        }
    }
}
