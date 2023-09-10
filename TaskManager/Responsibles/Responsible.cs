using System;

namespace TaskManager.Responsible
{
    /// <summary>
    /// Класс ответственных.
    /// </summary>
    public class Responsible
    {
        #region Поля и свойства

        /// <summary>
        /// Ид ответственного.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя ответственного.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Почта ответственного.
        /// </summary>
        public string Email { get; set; }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">Имя ответственного.</param>
        /// <param name="email">Почта ответственного.</param>
        public Responsible(string name, string email)
            : this(Guid.NewGuid(), name, email)
        {
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name">Имя ответственного.</param>
        /// <param name="email">Почта ответственного.</param>
        public Responsible(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        #endregion

        public override string ToString()
        {
            return $"{Name} - {Email}";
        }
    }
}