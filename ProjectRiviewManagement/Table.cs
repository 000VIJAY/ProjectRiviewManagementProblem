using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRiviewManagement
{
    internal class Table
    {
        public void createTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("productId");
            table.Columns.Add("userId");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");
            table.Rows.Add("1", "1", "5", "Nice", true);
            table.Rows.Add("2", "2", "4", "very good", true);
            table.Rows.Add("3", "3", "3", "Okay", true);
            table.Rows.Add("4", "4", "1", "very bad", false);
            table.Rows.Add("5", "5", "2", "bad", true);
            table.Rows.Add("6", "6", "4", "very good", false);
            table.Rows.Add("7", "7", "5", "Nice", false);
            table.Rows.Add("8", "8", "3", "Okay", false);
            table.Rows.Add("9", "9", "1", "very bad", true);
            table.Rows.Add("10", "10", "3", "Okay", false);
            table.Rows.Add("12", "11", "3", "Okay", true);
            table.Rows.Add("11", "12", "3", "Okay", true);
            table.Rows.Add("13", "13", "1", "very bad", true);
            table.Rows.Add("14", "14", "3", "Okay", true);
            table.Rows.Add("15", "15", "4", "very good", true);
            table.Rows.Add("16", "16", "5", "Nice", false);
            table.Rows.Add("17", "17", "3", "Okay", true);
            table.Rows.Add("18", "18", "2", "bad", false);
            table.Rows.Add("19", "19", "2", "bad", false);
            table.Rows.Add("20", "20", "4", "very good", true);
            table.Rows.Add("21", "21", "5", "Nice", true);
            table.Rows.Add("22", "22", "1", "very bad", false);
            table.Rows.Add("23", "23", "3", "Okay", true);
            table.Rows.Add("24", "24", "4", "very good", false);
            table.Rows.Add("25", "25", "2", "bad", true);
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row["ProductId"] + "\t|" + row["UserId"] + "\t|" + row["Review"] + "\t|" + row["Rating"] + "\t|" + row["Islike"]);
            }
        }
    }
}
