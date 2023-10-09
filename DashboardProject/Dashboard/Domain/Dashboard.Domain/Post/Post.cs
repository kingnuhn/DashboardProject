﻿using Dashboard.Domain.Base;

namespace Dashboard.Domain.Post
{
    /// <summary>
    /// Сущность объявлений
    /// </summary>
    public class Post : BaseEntity
    {
        /// <summary>
        /// Заголовок.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Идентификатор категории.
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Наименование тегов.
        /// </summary>
        public string[] TagName { get; set; }

    }
}
