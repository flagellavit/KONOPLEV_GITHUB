﻿


namespace CLUB.SERVICES.CONTRACTS.ModelRequest
{
    /// <summary>
    /// Место платежа от клиентов
    /// </summary>
    public abstract class WherePayReq
    {
        /// <summary>
        /// Название банка
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Кому платят
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Номер карты
        /// </summary>
        public string CardNumber { get; set; }

    }
}
