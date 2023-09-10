using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    internal class DBHelper
    {
        //internal static string pathDB = Path.Combine(Application.StartupPath, "dbase.db");
        internal static string pathDB = "dbase.db";

        internal static void CreateDB()
        {
            SQLiteConnection.CreateFile(pathDB);

            using (SQLiteConnection con = new SQLiteConnection(string.Format($"Data source={pathDB};")))

            {
                using (SQLiteCommand cmd = new SQLiteCommand(@"CREATE TABLE tb_tasks (
																			Id_task	INTEGER NOT NULL UNIQUE,
																			Task_name	TEXT NOT NULL,
																			Task_description	TEXT,
																			Dedline_days	INTEGER,
																			Id_priority	INTEGER,
																			Id_status	INTEGER,
																			Id	INTEGER,
																			Start_date	TEXT,
																			End_date	TEXT,
																			Note	TEXT,
																			PRIMARY KEY(Id_task AUTOINCREMENT));
																CREATE TABLE tb_responsible (
																			Id	INTEGER NOT NULL UNIQUE,
																			Name	TEXT,
																			Mail	TEXT,
																			PRIMARY KEY(Id AUTOINCREMENT)
																		);
																		CREATE VIEW v_all_tasks AS
																		SELECT  tb_tasks.Id_task,
																				tb_tasks.Task_name,
																				tb_tasks.Task_description,
																				tb_tasks.Id_status,
																				tb_tasks.Dedline_days,
																				tb_tasks.Start_date,
																				tb_tasks.End_date,
																				tb_tasks.Id_priority,
																				tb_tasks.Id,
																				tb_responsible.Name,
																				tb_responsible.Mail,
																				tb_tasks.Note
																		FROM tb_tasks 
																			 left join tb_responsible on tb_responsible.Id=tb_tasks.Id;", con))
														{
															try
															{
																con.Open();
																cmd.ExecuteNonQuery();
																MessageBox.Show($"Создан файл бд в {pathDB}");
                    }
															catch (Exception ex)
															{
																MessageBox.Show(ex.Message);
															}
															finally
															{
																con.Close();
															}

														}
            }
        }

		internal static List<Tasks> GetTasks()
		{
			//if (!File.Exists(pathDB)) 
			//{
			//CreateDB();
			//}
			try
			{
                using (SQLiteConnection con = new SQLiteConnection(string.Format($"Data source={pathDB};")))
				{
					con.Open();
					using (SQLiteCommand cmd = new SQLiteCommand(@"SELECT * FROM V_ALL_TASKS;", con))
					{
						using(var rdr = cmd.ExecuteReader())
						{
							List<Tasks> tasks = new List<Tasks>();
							while (rdr.Read()) 
							{
								tasks.Add(new Tasks
								{
                                    Id_task = rdr.GetInt32(0),
									Task_name = rdr.GetString(1),
									Task_description = rdr.GetString(2),
									Id_status=rdr.GetInt32(3),
									Dedline_days=rdr.GetInt32(4),
									Start_date = rdr.GetString(5),
									End_date = rdr.GetString(6),
									Id_priority = rdr.GetInt32(7),
									Id = rdr.GetInt32(8),
									Name = rdr.GetString(9),
									Mail = rdr.GetString(10),
									Note = rdr.GetString(11)
                                });
								
							}
							return tasks;
						}
					}

                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
            return null;
        }

        //internal static List<Responsible> GetResponsibles()
        //{
        //    //if (!File.Exists(pathDB)) 
        //    //{
        //    //CreateDB();
        //    //}
        //    try
        //    {
        //        using (SQLiteConnection con = new SQLiteConnection(string.Format($"Data source={pathDB};")))
        //        {
        //            con.Open();
        //            using (SQLiteCommand cmd = new SQLiteCommand(@"SELECT * FROM tb_responsible;", con))
        //            {
        //                using (var rdr = cmd.ExecuteReader())
        //                {
        //                    List<Responsible> resp = new List<Responsible>();
        //                    while (rdr.Read())
        //                    {
        //                        resp.Add(new Responsible
        //                        {
        //                            Id = rdr.GetInt32(0),
        //                            Name = rdr.GetString(1),
        //                            Mail = rdr.GetString(2)
                                    
        //                        });

        //                    }
        //                    return resp;
        //                }
        //            }

        //        }


        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message); }
        //    return null;
        //}
    }
}
