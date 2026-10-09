using System;
using System.Data;

public class Program
{
    public static void Main()
    {
        DataTable dt = new DataTable("Students");
        dt.Columns.Add("Id", typeof(int));
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("Age", typeof(int));
        dt.Columns.Add("GroupName", typeof(string));

        dt.Rows.Add(1, "Григрун Алексей", 18, "АлК-23");
        dt.Rows.Add(2, "Петрова Наташа", 20, "АлК-23");
        dt.Rows.Add(3, "Макалян Алексей", 18, "МКТ-43");
        dt.Rows.Add(4, "Улькина Ольга", 28, "МКТ-43");
        dt.Rows.Add(5, "Кузнецов Даниил", 19, "ТлК-11");

        foreach (DataRow row in dt.Rows)
        {
            Console.WriteLine($"#{row["Id"],-3} | {row["Name"],-20} | Возраст: {row["Age"],-2} | Группа: {row["GroupName"]}");
        }

        DataRow ot = null;
        int maxAge = 0;
        foreach (DataRow row in dt.Rows)
        {
            int currentAge = (int)row["Age"];
            if (currentAge > maxAge)
            {
                maxAge = currentAge;
                ot = row;
            }
        }
        Console.WriteLine($"\nСамый старший: {ot["Name"]} ({ot["Age"]} лет)");

        dt.Rows.Add(6, "Петренко Анастасия", 19, "АлК-23");
        foreach (DataRow row in dt.Rows)
        {
            Console.WriteLine($"#{row["Id"],-3} | {row["Name"],-20} | Возраст: {row["Age"],-2} | Группа: {row["GroupName"]}");
        }
    }
}
