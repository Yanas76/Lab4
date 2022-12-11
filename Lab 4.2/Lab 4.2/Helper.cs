using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab_4._2
{
    public static class Helper
    {
        public static void DisplayResult(List<Club> allData, DataTable table)
        {
            table.Clear();
            foreach (Club club in allData)
            {
                table.Rows.Add(club.ClubName, club.FacultyName, club.CathedraName, club.Day, club.Time, club.Chief, club.Orientation, club.HeadFullName);
            }
        }

        public static void Validator(string clubName, string facultyName, string cathedraName, string day, string time, string chief, string orientation, string headFullName)
        {
            if(String.IsNullOrWhiteSpace(clubName) || String.IsNullOrWhiteSpace(facultyName) || String.IsNullOrWhiteSpace(cathedraName) ||
                String.IsNullOrWhiteSpace(day)|| String.IsNullOrWhiteSpace(time) || String.IsNullOrWhiteSpace(chief) ||
                String.IsNullOrWhiteSpace(orientation) || String.IsNullOrWhiteSpace(headFullName))
            {
                throw new ArgumentException();
            }
        }
    }
}
