
using CLUB.SERVICES.CONTRACTS.Models;
using CLUB.SERVICES.CONTRACTS.ModelRequest;
namespace CLUB.SERVICES.CONTRACTS.Interface
{
    public interface IWherePlaceService
    {
        /// <summary>
        /// Получить список всех <see cref="WherePlace"/>
        /// </summary>
        Task<IEnumerable<WherePlace>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="WherePlace"/> по идентификатору
        /// </summary>
        Task<WherePlace?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Добавляет нового клиента
        /// </summary>
        Task<WherePlace> AddAsync(WherePlaceReq source, CancellationToken cancellationToken);

        /// <summary>
        /// Редактирует существующего клиента
        /// </summary>
        Task<WherePlace> EditAsync(WherePlaceReq source, CancellationToken cancellationToken);

        /// <summary>
        /// Удаляет существующего клиента
        /// </summary>
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
