using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26
{
    public class RegistrationDB
    {
        public static string REGISTR_DB_FILE_NAME = "registrations.txt";
        public static string PATH_TO_REGISTRATION_DB = System.IO.Directory.GetCurrentDirectory() + "\\" + REGISTR_DB_FILE_NAME;
        private static List<Registration> RegistrsList = new List<Registration>();

        public static void ShowPathToRegistrsDB() => MessageBox.Show(PATH_TO_REGISTRATION_DB);

        public static void CreateRegistrsDBFile()
        {
            FillRegistrsList();
            using (StreamWriter sw = new StreamWriter(PATH_TO_REGISTRATION_DB, false, Encoding.UTF8))
            {
                foreach (Registration rgstr in RegistrsList)
                {
                    sw.WriteLine(
                        $"{rgstr.Email}|" +
                        $"{rgstr.Distance5}|" +
                        $"{rgstr.Distance21}|" +
                        $"{rgstr.Distance42}|" + 
                        $"{rgstr.Equipment}|" +
                        $"{rgstr.VznosForFond}|" +
                        $"{rgstr.VznosForMaraphon}|" +
                        $"{rgstr.Fond}|" + 
                        $"{rgstr.RegistrationTime.Year}.{rgstr.RegistrationTime.Month}.{rgstr.RegistrationTime.Day}" 
                    );
                }
            }
        }

        public static void AddRegistrsToDBFile(Registration rgstr)
        {
            List<Registration> tempList = ReadRegistrationsDBFile();
            bool isItNewRegistr = true;

            foreach (Registration rgrsrr in tempList)
            {
                if (rgrsrr.Email == rgstr.Email)
                {
                    isItNewRegistr = false;
                    break;
                }
            }

            if (isItNewRegistr)
            {
                using (StreamWriter sw = new StreamWriter(PATH_TO_REGISTRATION_DB, true, Encoding.UTF8))
                {
                    sw.WriteLine(
                            $"{rgstr.Email}|" +
                            $"{rgstr.Distance5}|" +
                            $"{rgstr.Distance21}|" +
                            $"{rgstr.Distance42}|" +
                            $"{rgstr.Equipment}|" +
                            $"{rgstr.VznosForFond}|" +
                            $"{rgstr.VznosForMaraphon}|" + 
                            $"{rgstr.Fond}|" + 
                            $"{rgstr.RegistrationTime.Year}.{rgstr.RegistrationTime.Month}.{rgstr.RegistrationTime.Day}"
                        );
                }
                MessageBox.Show(
                    "Вы успешно зарегистрированы на марафон!", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            else MessageBox.Show("Вы уже зарегистрированы на марафон!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void FillRegistrsList()
        {
            RegistrsList.Add(
                new Registration(
                    "ted391@mail.ru", 
                    true, false, true,
                    0,
                    500.0,
                    185, 
                    "Фонд кошек", 
                    new DateTime(2024, 5, 10)
                )
            );
            RegistrsList.Add(
                new Registration(
                    "sna@yandex.ru", 
                    true, false, false,
                    2, 
                    2000.0, 
                    65,
                    "Фонд кошек",
                    new DateTime(2023, 12, 12)
                )
            );
        }

        public static List<Registration> ReadRegistrationsDBFile()
        {
            List<Registration> result = new List<Registration>();

            using (StreamReader sr = new StreamReader(PATH_TO_REGISTRATION_DB, Encoding.UTF8))
            {
                string tempString = "";
                string[] temp = new string[7];
                string[] dateTimeString = new string[3];
                int[] dateTime = new int[3];

                for (int i = 0; i < File.ReadAllLines(PATH_TO_REGISTRATION_DB).Length; i++)
                {
                    tempString = sr.ReadLine();
                    if (tempString != null)
                    {
                        temp = tempString.Split(new char[] { '|' });
                        dateTimeString = temp[8].Split(new char[] { '.' });

                        dateTime[0] = Convert.ToInt32(dateTimeString[0]);
                        dateTime[1] = Convert.ToInt32(dateTimeString[1]);
                        dateTime[2] = Convert.ToInt32(dateTimeString[2]);

                        result.Add(
                            new Registration(
                                temp[0], 
                                Boolean.Parse(temp[1]), Boolean.Parse(temp[2]), Boolean.Parse(temp[3]),
                                Convert.ToByte(temp[4]), Convert.ToDouble(temp[5]),
                                Convert.ToInt32(temp[6]), temp[7], 
                                new DateTime(dateTime[0], dateTime[1], dateTime[2])
                            )
                        );
                    }
                }
            }

            return result;
        }
    }
}
