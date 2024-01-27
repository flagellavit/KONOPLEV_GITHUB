
using CLUB.SERVICES.CONTRACTS.Models;
using CLUB.SERVICES.CONTRACTS.ModelRequest;

namespace CLUB.SERVICES.CONTRACTS.Interface
{
    public interface IWherePayService
    {
        /// <summary>
        /// Получить список всех <see cref="WherePay"/>
        /// </summary>
        Task<IEnumerable<WherePay>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="WherePay"/> по идентификатору
        /// </summary>
        Task<WherePay?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Добавляет нового клиента
        /// </summary>
        Task<WherePay> AddAsync(WherePayReq source, CancellationToken cancellationToken);

        /// <summary>
        /// Редактирует существующего клиента
        /// </summary>
        Task<WherePay> EditAsync(WherePayReq source, CancellationToken cancellationToken);

        /// <summary>
        /// Удаляет существующего клиента
        /// </summary>
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
