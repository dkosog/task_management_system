using System;
using System.Collections.Generic;

namespace TaskManager.Responsible
{
    /// <summary>
    /// Класс работы с ответственными.
    /// </summary>
    public class ResponsibleService
    {
        #region Поля и свойства

        /// <summary>
        /// Коллекция ответсвенных.
        /// </summary>
        private List<Responsible> responsibles = new List<Responsible>();

        #endregion

        #region Методы

        #region AddResponsible
        /// <summary>
        /// Добавить ответственного.
        /// </summary>
        /// <param name="responsible">Данные ответственного.</param>
        public void AddResponsible(Responsible responsible)
        {
            responsibles.Add(responsible);
        }

        /// <summary>
        /// Добавить ответственного.
        /// </summary>
        /// <param name="name">Имя ответственного.</param>
        /// <param name="email">Почта ответственного.</param>
        public void AddResponsible(string name, string email)
        {
            responsibles.Add(new Responsible(name, email));
        }

        #endregion

        /// <summary>
        /// Получение коллекции ответственных.
        /// </summary>
        /// <returns>Коллекция ответственных.</returns>
        public List<Responsible> GetResponsibles()
        {
            return responsibles;
        }

        /// <summary>
        /// Установить список в коллекцию ответственных.
        /// </summary>
        /// <param name="responsibles">Коллекция ответственных которую требуется установить.</param>
        public void SetResponsibles(List<Responsible> responsibles)
        {
            this.responsibles = responsibles;
        }

        #region RemoveResponsible
        /// <summary>
        /// Удаление ответственного.
        /// </summary>
        /// <param name="responsible"></param>
        public void RemoveResponsible(Responsible responsible)
        {
            responsibles.Remove(responsible);
        }

        /// <summary>
        /// Удаление ответственного.
        /// </summary>
        /// <param name="name">Имя ответственного.</param>
        /// <param name="email">Почта ответственного.</param>
        public void RemoveResponsible(string name, string email)
        {
            responsibles.Remove(new Responsible(name, email));
        }

        /// <summary>
        /// Удаление ответственного по индексу.
        /// </summary>
        /// <param name="index">Индекс ответственного.</param>
        public void RemoveResponsible(int index)
        {
            responsibles.RemoveAt(index);
        }

        /// <summary>
        /// Удаление ответственного по индексу.
        /// </summary>
        /// <param name="id">Ид ответственного.</param>
        public void RemoveResponsible(Guid id)
        {
            Responsible responsible = this.GetResponsible(id);
            responsibles.Remove(responsible);
        }

        #endregion

        #region UpdateResponsible

        /// <summary>
        /// Обновить данные ответственного в коллекции.
        /// </summary>
        /// <param name="responsible">Ответственный.</param>
        /// <param name="name">Новое имя ответственного.</param>
        /// <param name="email">Новая почта ответственного.</param>
        public void UpdateResponsible(Responsible responsible, string name, string email)
        {
            responsible.Name = name;
            responsible.Email = email;
        }

        /// <summary>
        /// Обновить данные ответственного в коллекции по индексу.
        /// </summary>
        /// <param name="index">Индекс ответственного.</param>
        /// <param name="name">Новое имя ответственного.</param>
        /// <param name="email">Новая почта ответственного.</param>
        public void UpdateResponsible(int index, string name, string email)
        {
            responsibles[index].Name = name;
            responsibles[index].Email = email;
        }

        /// <summary>
        /// Обновить данные ответственного в коллекции по индексу.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        public void UpdateResponsible(Guid id, string name, string email)
        {
            Responsible responsible = this.GetResponsible(id);
            responsible.Name = name;
            responsible.Email = email;
        }

        #endregion

        #region GetResponsible

        /// <summary>
        /// Поиск ответственного по имени и почте.
        /// </summary>
        /// <param name="name">Имя ответственного.</param>
        /// <param name="email">Почта ответственного.</param>
        /// <returns>Данные ответственного.</returns>
        public Responsible GetResponsible(string name, string email)
        {
            return responsibles.Find(responsible => responsible.Name == name && responsible.Email == email);
        }

        /// <summary>
        /// Поиск ответственного по ид.
        /// </summary>
        /// <param name="id">Уникальный ид пользователя.</param>
        /// <returns>Данные ответственного.</returns>
        public Responsible GetResponsible(Guid id)
        {
            return responsibles.Find(responsible => responsible.Id == id);
        }

        /// <summary>
        /// Поиск ответственного по индексу.
        /// </summary>
        /// <param name="index">Индекс ответственного.</param>
        /// <returns>Данные ответственного.</returns>
        public Responsible GetResponsible(int index)
        {
            return responsibles[index];
        }

        #endregion

        /// <summary>
        /// Очистить коллекцию ответственных.
        /// </summary>
        public void ClearResponsibles()
        {
            responsibles.Clear();
        }

        /// <summary>
        /// Получение кол-ва ответственных в коллекции.
        /// </summary>
        /// <returns>Кол-во ответственных.</returns>
        public int GetResponsiblesCount()
        {
            return responsibles.Count;
        }

        #endregion
    }
}