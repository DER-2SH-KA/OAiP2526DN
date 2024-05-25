using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_26
{
    internal class UsersResult
    {
        private static string Users_Result_File = "UsersResultFile.txt";
        public static string Path_To_Users_Result_File = System.IO.Directory.GetCurrentDirectory() + "\\" + Users_Result_File;

        private static string[] massiv =
        {
            "ted391@mail.ru|m|18-29|2014 Japan|42km Full Marathon|4.04.12|#1|1|Дмитриев.А|RU|t",
            "ted391@mail.r|m|18-29|2013 Germany|21km Full Marathon|4.15.25|#2|1|Дмитриев.А|RU|t",
            "ted391@mail.ru|m|18-29|2012 Vietnam|5km Full Marathon|4.34.12|#4|1|Дмитриев.А|RU|t",
            "sna@yandex.ru|f|18-29|2014 Japan|42km Full Marathon|6.04.12|#6|2|Суслякова.Н|RU|t",
            "sna@yandex.ru|f|18-29|2013 Germany|42km Full Marathon|6.12.12|#6|2|Суслякова.Н|RU|t",
            "sna@yandex.ru|f|18-29|2011 UK|42km Full Marathon|3.04.23|#1|1|Суслякова.Н|RU|t",
            "qw@e|m|18-29|2014 Japan|42km Full Marathon|5.09.06|#3|2|Иванов.С|RU|t",
            "w@e|f|30-40|2014 Japan|21km Semi Marathon|5.09.06|#4|2|Иванова.С|RU|t",
        };

        public static void CreateUserResultsDBFile()
        {
            using (StreamWriter sw = new StreamWriter(Path_To_Users_Result_File, false, Encoding.UTF8))
            {
                foreach (string user in massiv)
                {
                    sw.WriteLine(user);
                }
            }
        }
    }
}
