using Acme.BookStore.DataTransmitModel.Books;
using Acme.BookStore.Model.Books;
using Acme.BookStore.PresentationModel.Books;
using Acme.BookStore.Service;
using Materal.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.ServiceImpl
{
    /// <summary>
    /// 图书服务的实现
    /// </summary>
    public class BookAppService :
        CrudAppService<
        Book, //图书实体
        BookDto, //用来展示书籍
        Guid, //图书实体的主键
        PagedAndSortedResultRequestDto, //用于分页和排序
        CreateBookRequestModel, //用于创建/更新一本书
        UpdateBookRequestModel>, //用于更新一本书
        IBookAppService //实现IBookAppService
    {
        /// <summary>
        /// 构造方法
        /// 注入IRepository <Book,Guid>,这是Book实体的默认仓储. ABP自动为每个聚合根(或实体)创建默认仓储
        /// </summary>
        /// <param name="repository"></param>
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {

        }

        public Task<List<BookDto>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        ///<summary>
        /// 获取图书数据
        /// </summary>
        /// <param name="model">查询图书请求模型</param>
        /// <returns></returns>
        public Task<(List<BookDto> result, PageModel pageModel)> GetBookListAsync(QueryBookFilterRequestModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取图书细信息
        /// </summary>
        /// <param name="id">图书唯一标识ID</param>
        /// <returns></returns>
        public Task<BookDto> GetBookInfoAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 添加图书信息
        /// </summary>
        /// <param name="model">添加图书信息请求模型</param>
        /// <returns></returns> 
        public Task AddBookInfoAsync(CreateBookRequestModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改图书信息
        /// </summary>
        /// <param name="model">修改图书信息请求模型</param>
        /// <returns></returns>
        public Task EditBookInfoAsync(UpdateBookRequestModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <param name="id">图书唯一标识ID</param>
        /// <param name="userID">当前用户ID</param>
        /// <returns></returns>
        public Task BatchDeleteBookAsync(List<Guid> ids, Guid userID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 批量删除图书信息
        /// </summary>
        /// <param name="ids">图书ID集合</param>
        /// <param name="userID">当前用户ID</param>
        /// <returns></returns>
        public Task DeleteBookInfoAsync(Guid id, Guid userID)
        {
            throw new NotImplementedException();
        }

       
    }
}