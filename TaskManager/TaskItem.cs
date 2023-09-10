using System;

namespace TaskManager
{
  /// <summary>
  /// Класс отвечающий за задачи.
  /// </summary>
  internal class TaskItem
  {
    #region Свойства
    /// <summary>
    /// Id задачи.
    /// </summary>
    public Guid ID { get; set; }

    /// <summary>
    /// Наименование задачи.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Статус задачи.
    /// </summary>
    public Status Status { get; set; }

    /// <summary>
    /// Дней на исполнение.
    /// </summary>
    public int Deadline { get; set; }

    /// <summary>
    /// Приоритет задачи.
    /// </summary>
    public Priority Priority{ get; set; }

    /// <summary>
    /// Комментарий к задачи.
    /// </summary>
    public string Comments { get; set; }

    /// <summary>
    /// Описание задачи.
    /// </summary>
    public string Disciption { get; set; }

    /// <summary>
    /// Ответсвенные.
    /// </summary>
    public Responsible Responsible { get; set; }
    #endregion

    #region Конструкор
    /// <summary>
    /// Конструктор для создание задачи.
    /// </summary>
    /// <param name="name">Название</param>
    /// <param name="disciption">Описание задачи</param>
    /// <param name="status">Cтатус задачи</param>
    /// <param name="deadline">Количество дней на выполнение задачи</param>
    /// <param name="priority">Приоритет</param>
    /// <param name="responsible">Ответсвенный</param>
    /// <param name="comments">Комментарий</param>
    public TaskItem(string name, string disciption, Status status, int deadline, Priority priority, Responsible responsible, string comments)
    {
      ID = Guid.NewGuid();
      Name = name;
      Disciption = disciption;
      Status = status;
      Priority = priority;
      Responsible = responsible;
      Comments = comments;
      Deadline = deadline;
    }
    #endregion
  }

  #region Перечисление
  /// <summary>
  /// Перечисление статусов: Не взята в работу, Взята в работу, На проверке, Завершена.
  /// </summary>
  public enum Status : byte
  { 
    NotHired, 
    Hired,
    UnderReview, 
    Completed
  }

  /// <summary>
  /// Перечисление приоритетов: Очень низкий, Низкий, Средний, Высокий, Срочный.
  /// </summary>
  public enum Priority
  {
    VeryLow,
    Low,
    Average,
    High,
    Urgent
  }
  #endregion
}
