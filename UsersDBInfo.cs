using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace _25_26
{
    public class UsersDBInfo
    {
        public static string USERS_DB_FILE_NAME = "users.txt";
        public static string PATH_TO_USERS_DB = System.IO.Directory.GetCurrentDirectory() + "\\" + USERS_DB_FILE_NAME;
        private static List<User> UsersList = new List<User>();

        public static void ShowPathToUsersDB() => MessageBox.Show(PATH_TO_USERS_DB);

        public static void CreateUsersDBFile() 
        {
            FillUsersList();
            using (StreamWriter sw = new StreamWriter(PATH_TO_USERS_DB, false, Encoding.UTF8)) 
            {
                foreach (User user in UsersList) 
                {
                    sw.WriteLine(
                        $"{user.Email}|{user.Password}|{user.FirstName}|" +
                        $"{user.SecondName}|{user.Sex}|{user.PathToPhoto}|" +
                        $"{user.Bithday.Year}.{user.Bithday.Month}.{user.Bithday.Day}|" +
                        $"{user.Country}"
                    );
                }
            }
        }

        public static void AddUserToDBFile(User user)
        {
            List<User> tempList = ReadUsersDBFile();
            bool isItNewUser = true;

            foreach (User userr in tempList) 
            {
                if (userr.Email == user.Email) 
                {
                    isItNewUser = false;
                    break;
                }
            }

            if (isItNewUser)
            {
                using (StreamWriter sw = new StreamWriter(PATH_TO_USERS_DB, true, Encoding.UTF8))
                {
                    sw.WriteLine(
                        $"{user.Email}|{user.Password}|{user.FirstName}|" +
                        $"{user.SecondName}|{user.Sex}|{user.PathToPhoto}|" +
                        $"{user.Bithday.Year}.{user.Bithday.Month}.{user.Bithday.Day}|" +
                        $"{user.Country}"
                    );
                    MessageBox.Show(
                        "Новый аккаунт был зарегистрирован успешно!", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            else MessageBox.Show("Пользователь с такой электронной почтой уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void EditUserToDBFile(User user)
        {
            List<User> tempList = ReadUsersDBFile();

            for (int i = 0; i < tempList.Count; i++) 
            {
                if (tempList[i].Email == user.Email) 
                {
                    tempList[i] = user;
                    break;
                }
            }

            using (StreamWriter sw = new StreamWriter(PATH_TO_USERS_DB, false, Encoding.UTF8))
            {
                for (int i = 0; i < tempList.Count; i++)
                {
                    sw.WriteLine(
                        $"{tempList[i].Email}|{tempList[i].Password}|{tempList[i].FirstName}|" +
                        $"{tempList[i].SecondName}|{tempList[i].Sex}|{tempList[i].PathToPhoto}|" +
                        $"{tempList[i].Bithday.Year}.{tempList[i].Bithday.Month}.{tempList[i].Bithday.Day}|" +
                        $"{tempList[i].Country}"
                    );
                }
            }
            MessageBox.Show(
                "Аккаунт был успешно отредактирован!", "Уведомление",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private static void FillUsersList() 
        {
            UsersList.Add(
                new User(
                    "ted391@mail.ru", "AZAZAZA",
                    "Anatoliy", "Dmitriev",
                    0, "O:\\MYDESKTOP\\Pictures\\Fun\\AnatoliyEduardovich.jpg",
                    new DateTime(2006, 2, 22), 0
                )
            );
            UsersList.Add(
                new User(
                    "sna@yandex.ru", "Passw0rd",
                    "Natalya", "Suslyakova",
                    1, "O:\\MYDESKTOP\\Pictures\\Fun\\Avatar2.jpg",
                    new DateTime(2005, 12, 11), 1
                )
            );
        }

        public static List<User> ReadUsersDBFile() 
        {
            List<User> result = new List<User>();

            using (StreamReader sr = new StreamReader(PATH_TO_USERS_DB, Encoding.UTF8)) 
            {
                string tempString = "";
                string[] temp = new string[8];
                string[] dateTimeString = new string[3];
                int[] dateTime = new int[3];

                for (int i = 0; i < File.ReadAllLines(PATH_TO_USERS_DB).Length; i++) 
                {
                    tempString = sr.ReadLine();
                    if (tempString != null) 
                    {
                        temp = tempString.Split(new char[] { '|' });
                        dateTimeString = temp[6].Split(new char[] { '.' });

                        dateTime[0] = Convert.ToInt32(dateTimeString[0]);
                        dateTime[1] = Convert.ToInt32(dateTimeString[1]);
                        dateTime[2] = Convert.ToInt32(dateTimeString[2]);

                        result.Add(
                            new User(
                                temp[0], temp[1], temp[2], temp[3],
                                Convert.ToByte(temp[4]), temp[5], 
                                new DateTime(dateTime[0], dateTime[1], dateTime[2]),
                                Convert.ToInt32(temp[7])
                            )
                        );
                    }
                }
            }

            return result;
        }
    }
}
