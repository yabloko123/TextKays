using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validator_Vertyachikh;

namespace Validator_Vertyachikh
{
    /// <summary>
    /// by ryzenvpn/vertyachikh: класс отвечает за получение данных из локального сервиса TransferSimulator.
    /// </summary>
    public static class GetFromAPI
    {
        /// <summary>
        /// by ryzenvpn/vertyachikh: отправляет GET-запрос к API, читает поле value из JSON и обновляет флаги результата.
        /// </summary>
        /// <returns>ФИО из API или строка Error, если запрос не удалось выполнить.</returns>
        public static string APIResult()
        {
            try
            {
                string FIO;
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:4444/TransferSimulator/fullName");
                request.Method = "GET";
                request.Credentials = new NetworkCredential("student", "student");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    var json = JObject.Parse(reader.ReadToEnd());
                    FIO = json["value"]?.ToString() ?? "";
                }
                if (FIO == null || FIO.Length == 0 || FIO == "")
                {
                    Results.IsGet = false;
                    Results.IsCorrect = false;
                    ResultToWord.SaveResults();
                }
                else
                {
                    Results.IsGet = true;
                }
                return FIO;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения данных: '{ex.Message}'");
                Results.IsGet = false;
                return "Error";
            }
        }
    }
}
