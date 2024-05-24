using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26
{
    public class SponsorsDB
    {
        public static string SPONSOR_DB_FILE_NAME = "sponsors.txt";
        public static string PATH_TO_SPONSOR_DB = System.IO.Directory.GetCurrentDirectory() + "\\" + SPONSOR_DB_FILE_NAME;
        private static List<Sponsor> SponsorList = new List<Sponsor>();

        public static void ShowPathToRegistrsDB() => MessageBox.Show(PATH_TO_SPONSOR_DB);

        public static void CreateSponsorsDBFile()
        {
            FillSponsorsList();
            using (StreamWriter sw = new StreamWriter(PATH_TO_SPONSOR_DB, false, Encoding.UTF8))
            {
                foreach (Sponsor spnsr in SponsorList)
                {
                    sw.WriteLine(
                        $"{spnsr.Name}|" +
                        $"{spnsr.PathToPhoto}|" +
                        $"{spnsr.Description}|"
                    );
                }
            }
        }

        private static void FillSponsorsList()
        {
            SponsorList.Add(
                new Sponsor(
                    "Фонд кошек",
                    $"{Directory.GetCurrentDirectory() + "\\resource\\CatsFond.jpg"}", 
                    "Кошачий фонд — это организация, созданная для поддержки и защиты кошек и их владельцев. " +
                    "Фонд предоставляет различные услуги и программы, направленные на улучшение качества жизни кошек и их хозяев." +
                    "Фонд финансирует исследования в области ветеринарии, зоозащиты и психологии, чтобы разрабатывать новые методы лечения и " +
                    "профилактики заболеваний кошек, а также повышать осведомлённость населения о важности заботы о домашних питомцах." +
                    "Фонд также организует образовательные мероприятия, семинары и конференции для владельцев кошек, где они могут " +
                    "получить информацию о правильном уходе за своими питомцами, обучении и воспитании. Кроме того, фонд поддерживает " +
                    "приюты для животных, предоставляя им финансовую помощь, оборудование и волонтёров для помощи в уходе за кошками." +
                    "Фонд также работает над созданием программ по стерилизации и кастрации бездомных кошек, чтобы снизить количество " +
                    "бездомных животных на улицах. Кошачий фонд активно сотрудничает с государственными и частными организациями, " +
                    "а также с волонтёрскими движениями для достижения своих целей."
                )
            );
        }

        public static List<Sponsor> ReadSponsorsDBFile()
        {
            List<Sponsor> result = new List<Sponsor>();

            using (StreamReader sr = new StreamReader(PATH_TO_SPONSOR_DB, Encoding.UTF8))
            {
                string tempString = "";
                string[] temp = new string[3];

                for (int i = 0; i < File.ReadAllLines(PATH_TO_SPONSOR_DB).Length; i++)
                {
                    tempString = sr.ReadLine();
                    if (tempString != null)
                    {
                        temp = tempString.Split(new char[] { '|' });
                        // MessageBox.Show(temp[0]);
                        // MessageBox.Show(temp[1]);
                        // MessageBox.Show(temp[2]);
                        result.Add(
                            new Sponsor(
                               temp[0], temp[1], temp[2]
                            )
                        );
                    }
                }
            }

            return result;
        }
    }
}
