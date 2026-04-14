using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator_Vertyachikh
{
    /// <summary>
    /// by ryzenvpn/vertyachikh: хранит общий статус получения данных и проверки ФИО, чтобы Form1, GetFromAPI и ResultToWord использовали один результат.
    /// </summary>
    public static class Results
    {
        /// <summary>
        /// by ryzenvpn/vertyachikh: true, если ФИО успешно получено из API; false, если запрос завершился ошибкой или вернул пустое значение.
        /// </summary>
        public static bool IsGet { get; set; }

        /// <summary>
        /// by ryzenvpn/vertyachikh: true, если полученное ФИО прошло проверку регулярным выражением; false, если данные некорректны.
        /// </summary>
        public static bool IsCorrect { get; set; }
    }
}
