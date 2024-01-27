﻿
using CLUB.SERVICES.CONTRACTS.Enums;

namespace CLUB.SERVICES.CONTRACTS.ModelRequest
{
    /// <summary>
    /// Мужчины, что "свободны"
    /// </summary>
    public abstract class FreeMenReq
    {
        /// <summary>
        /// ФИО Мужчины
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// О мужчине
        /// </summary>
        public string? AboutHim { get; set; } = string.Empty;

        /// <summary>
        /// Со скольки доступен
        /// </summary>
        public TimeOnly OpenTime { get; set; }

        /// <summary>
        /// До скольки доступен
        /// </summary>
        public TimeOnly CloseTime { get; set; }

        /// <summary>
        /// Основной язык
        /// </summary>
        public string MainTongue { get; set; }

        /// <summary>
        /// Уровень мастерства
        /// </summary>
        public GradeTypes Grade { get; set; }




    }
}
