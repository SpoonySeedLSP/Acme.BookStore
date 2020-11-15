using Acme.BookStore.Service;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore
{
    /// <summary>
    /// 当客户端调用服务方法的时候动态客户端代理就会创建一个HTTP调用
    /// </summary>
    public class MyService : ITransientDependency
    {
        private readonly IBookAppService _bookService;

        public MyService(IBookAppService bookService)
        {
            _bookService = bookService;
        }

        public async Task DoIt()
        {
            var books = await _bookService.GetListAsync();
            foreach (var book in books)
            {
                Console.WriteLine($"[BOOK {book.Id}] Name={book.Name}");
            }
        }


    }
}
