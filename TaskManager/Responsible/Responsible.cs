namespace TaskManager.Responsible
{
    /// <summary>
    /// Класс ответственных.
    /// </summary>
    public class Responsible
    {
        #region Поля и свойства

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
        {
            Name = name;
            Email = email;
        }

        #endregion

        #region Методы

        public override string ToString()
        {
            return $"{Name} - {Email}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Responsible responsible = obj as Responsible;

            if (responsible == null)
                return false;

            return Name == responsible.Name && Email == responsible.Email;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Email.GetHashCode();
        }

        #endregion
    }
}
