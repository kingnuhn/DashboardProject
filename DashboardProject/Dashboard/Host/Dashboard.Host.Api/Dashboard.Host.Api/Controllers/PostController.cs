using Dashboard.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Host.Api.Controllers
{
    /// <summary>
    /// Контроллер для работы с объявлениями.
    /// </summary>
    public class PostController : ControllerBase
    {
        /// <summary>
        /// Получает объявление по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объявление.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Модель объявления<see cref="PostDto"/returns>
        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }
        /// <summary>
        /// Возвращает постраничные объявления.
        /// </summary>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <param name="pageSize">Размер страницы</param>
        /// <param name="pageIndex">Номер страницы</param>
        /// <returns>Коллекция объявлений<see cref="PostDto"/returns>
        [HttpGet("get-by-paged")]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
        {
            return Ok();
        }
        /// <summary>
        /// Создает объявление.
        /// </summary>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateAsync(PostDto dto, CancellationToken cancellationToken)
        {
            return Created(string.Empty, null);
        }

        /// <summary>
        /// Редактируем объявления.
        /// </summary>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Guid Id, CancellationToken cancellationToken)
        {
            return Ok();
        }
        /// <summary>
        /// Удаление объявления.
        /// </summary>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// /// <param name="id">Идентификатор объявление.</param>
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();





        }
    }
}
