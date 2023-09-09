using System;

namespace TaskManager
{
  /// <summary>
  /// Класс отвечающий за задачи.
  /// </summary>
  internal class TaskItem
  {
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
    /// Дата создание задачи.
    /// </summary>
    public DateTime DateStart { get; set; }

    /// <summary>
    /// Дата завершение задачи.
    /// </summary>
    public DateTime DateEnd { get; set; }

    /// <summary>
    /// Дней на исполнение.
    /// </summary>
    public int Deadlines { get; set; }

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

    /// <summary>
    /// Конструктор для создание задачи.
    /// </summary>
    /// <param name="name">Название</param>
    /// <param name="disciption">Описание задачи</param>
    /// <param name="status">Cтатус задачи</param>
    /// <param name="dateStart">Дата старта задачи</param>
    /// <param name="dateEnd">Дата окончания задачи</param>
    /// <param name="priority">Приоритет</param>
    /// <param name="responsible">Ответсвенный</param>
    /// <param name="comments">Комментарий</param>
    public TaskItem(string name, string disciption, Status status, DateTime dateStart, DateTime dateEnd, Priority priority, Responsible responsible, string comments)
    {
      ID = Guid.NewGuid();
      Name = name;
      Disciption = disciption;
      Status = status;
      DateStart = dateStart;
      DateEnd = dateEnd;
      Priority = priority;
      Responsible = responsible;
      Comments = comments;
      Deadlines = (dateEnd - dateStart).Days;
    }
  }

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
}
