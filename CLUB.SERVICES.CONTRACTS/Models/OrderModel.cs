


namespace CLUB.SERVICES.CONTRACTS.Models
{
    /// <summary>
    /// Бронирование
    /// </summary>
    public abstract class Order
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Номер свободного мужчины
        /// </summary>
        public FreeMen FreeMen { get; set; }

        /// <summary>
        /// Номер услуги
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Номер клиента
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        /// Номер места
        /// </summary>
        public WherePlace? WherePlace { get; set; }

        /// <summary>
        /// Номер оплаты
        /// </summary>
        public WherePay? WherePay { get; set; }

        /// <summary>
        /// Время заказа
        /// </summary>
        public DateTime OrderTime { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Комментарий к заказу
        /// </summary>
        public string? Comment { get; set; } = string.Empty;

    }
}
