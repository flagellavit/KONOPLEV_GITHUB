﻿


namespace CLUB.API.Models

{
    /// <summary>
    /// Клиенты
    /// </summary>
    public abstract class ClientResp
    {
        /// <summary>
        /// ФИО Клиента
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// E-почта
        /// </summary>
        public string? Email { get; set; } = string.Empty;

        /// <summary>
        /// О клиенте
        /// </summary>
        public string AboutHim { get; set; }

    }
}
