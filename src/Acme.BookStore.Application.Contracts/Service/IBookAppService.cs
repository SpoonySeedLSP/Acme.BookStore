using Acme.BookStore.DataTransmitModel.Books;
using Acme.BookStore.PresentationModel.Books;
using Materal.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Service
{
    /// <summary>
    /// 图书服务
    /// </summary>
    public interface IBookAppService:
         ICrudAppService< //定义了常见的CRUD方法:GetAsync,GetListAsync,CreateAsync,UpdateAsync和DeleteAsync。也可以从空的
         BookDto, //用来展示书籍
         Guid, //图书实体的主键
         PagedAndSortedResultRequestDto, //用于分页和排序
         CreateBookRequestModel, //用于创建一本书
         UpdateBookRequestModel>,//用于更新一本书
         IApplicationService
    {
        Task<List<BookDto>> GetListAsync();

        ///<summary>
        /// 获取图书数据
        /// </summary>
        /// <param name="model">查询图书请求模型</param>
        /// <returns></returns>
        Task<(List<BookDto> result, PageModel pageModel)> GetBookListAsync
            (QueryBookFilterRequestModel model);

        /// <summary>
        /// 获取图书细信息
        /// </summary>
        /// <param name="id">图书唯一标识ID</param>
        /// <returns></returns>
        Task<BookDto> GetBookInfoAsync(Guid id);

        /// <summary>
        /// 添加图书信息
        /// </summary>
        /// <param name="model">添加图书信息请求模型</param>
        /// <returns></returns> 
        Task AddBookInfoAsync(CreateBookRequestModel model);

        /// <summary>
        /// 修改图书信息
        /// </summary>
        /// <param name="model">修改图书信息请求模型</param>
        /// <returns></returns>
        Task EditBookInfoAsync(UpdateBookRequestModel model);

        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <param name="id">图书唯一标识ID</param>
        /// <param name="userID">当前用户ID</param>
        /// <returns></returns>
        Task DeleteBookInfoAsync(Guid id, Guid userID);

        /// <summary>
        /// 批量删除图书信息
        /// </summary>
        /// <param name="ids">图书ID集合</param>
        /// <param name="userID">当前用户ID</param>
        /// <returns></returns>
        Task BatchDeleteBookAsync(List<Guid> ids, Guid userID);
    }
}
