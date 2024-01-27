


namespace CLUB.SERVICES.CONTRACTS.Models
{
    /// <summary>
    /// Место бронирования
    /// </summary>
    public abstract class WherePlace
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Название места
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Со скольки открыто
        /// </summary>
        public TimeOnly OpenTime { get; set; }

        /// <summary>
        /// До скольки открыто
        /// </summary>
        public TimeOnly CloseTime { get; set; }

    }
}
