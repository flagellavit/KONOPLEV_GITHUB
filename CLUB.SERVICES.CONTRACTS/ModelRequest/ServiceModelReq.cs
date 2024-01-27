


namespace CLUB.SERVICES.CONTRACTS.ModelRequest
{
    /// <summary>
    /// Мужчины, что "свободны"
    /// </summary>
    public abstract class ServiceReq
    {
        /// <summary>
        /// Название услуги
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Описание услуги
        /// </summary>
        public string AboutService { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; } = 0;




    }
}
