using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Responsible;

namespace TaskManager
{
  /// <summary>
  /// класс для работы с задачами.
  /// </summary>
  internal class TaskService
  {
    /// <summary>
    /// Коллекция задач.
    /// </summary>
    private List<TaskItem> tasks = new List<TaskItem>();

    /// <summary>
    /// Добавление задачи.
    /// </summary>
    /// <param name="task"></param>
    public void AddTask(TaskItem task) 
    { 
      tasks.Add(task); 
    }

    /// <summary>
    /// Добавление задачи.
    /// </summary>
    /// <param name="name">Название задачи</param>
    /// <param name="disciption">Описание задачи</param>
    /// <param name="status">Статус</param>
    /// <param name="deadline">Количество дней на выполнение задачи</param>
    /// <param name="priority">Приоритет задачи</param>
    /// <param name="responsible">Ответсвенные</param>
    /// <param name="comments">Комментарий</param>
    public void AddTask(string name, string disciption, Status status, int deadline, Priority priority, Responsible responsible, string comments)
    {
      tasks.Add(new TaskItem(name, disciption, status, deadline, priority, responsible, comments));
    }

    /// <summary>
    /// Получить коллекцию задач.
    /// </summary>
    /// <returns>Коллекция задач</returns>
    public List<TaskItem> GetTasks()
    {
      return tasks;
    }

    /// <summary>
    /// Установить коллекцию задач.
    /// </summary>
    /// <param name="tasks"></param>
    public void SetTask(List<TaskItem> tasks)
    {
      this.tasks = tasks;
    }

    /// <summary>
    /// Удалить задачу.
    /// </summary>
    /// <param name="task">задача</param>
    public void RemoveTask(TaskItem task)
    {
      tasks.Remove(task);
    }

    /// <summary>
    /// Удалить задачу.
    /// </summary>
    /// <param name="name">Название задачи</param>
    /// <param name="disciption">Описание задачи</param>
    /// <param name="status">Статус</param>
    /// <param name="deadline">Количество дней на выполнение задачи</param>
    /// <param name="priority">Приоритет задачи</param>
    /// <param name="responsible">Ответсвенные</param>
    /// <param name="comments">Комментарий</param>
    public void RemoveTask(string name, string disciption, Status status, int deadline, Priority priority, Responsible responsible, string comments)
    {
      tasks.Remove(new TaskItem(name, disciption, status, deadline, priority, responsible, comments));
    }

    /// <summary>
    /// Удалить задачу по индексу.
    /// </summary>
    /// <param name="index">Индекс задачи</param>
    public void RemoveTask(int index)
    {
      tasks.RemoveAt(index);
    }

    /// <summary>
    /// Получить задачу по id.
    /// </summary>
    /// <param name="id">id</param>
    /// <returns>Задача</returns>
    public TaskItem GetTask(Guid id)
    {
      return tasks.Find(task => task.ID == id);
    }

    /// <summary>
    /// Получить задачу по индексу.
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public TaskItem GetTask(int index)
    {
      return tasks[index];
    }

    /// <summary>
    /// Очистить коллекцию задач.
    /// </summary>
    public void ClearTasks()
    {
      tasks.Clear();
    }

    /// <summary>
    /// Получение количество задач в коллекции.
    /// </summary>
    /// <returns>количество задач.</returns>
    public int GetTasksCount()
    {
      return tasks.Count;
    }
  }
}
