using System;

namespace TaskManager
{
    internal class Tasks
    {
        public int Id_task { get; internal set; }
        public string Task_name { get; internal set; }
        public string Task_description { get; internal set; }
        public int Id_status { get; internal set; }
        public int Dedline_days { get; internal set; }
        public string Start_date { get; internal set; }
        public string End_date { get; internal set; }
        public int Id_priority { get; internal set; }
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Mail { get; internal set; }
        public string Note { get; internal set; }
    }
}