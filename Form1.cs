using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validator_Vertyachikh;

namespace Validator_Vertyachikh
{
    /// <summary>
    /// by ryzenvpn/vertyachikh: главная форма приложения, через которую пользователь получает ФИО, проверяет его и записывает результат в документ.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// by ryzenvpn/vertyachikh: создает форму и инициализирует все элементы интерфейса из Form1.Designer.cs.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// by ryzenvpn/vertyachikh: обработчик загрузки формы, оставлен для возможной логики при старте окна.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// by ryzenvpn/vertyachikh: получает ФИО из локального API, выводит его на форму и показывает ошибку при неудачном запросе.
        /// </summary>
        private void buttonGet_Click(object sender, EventArgs e)
        {

            labelFIO.Text = GetFromAPI.APIResult();
            if (labelFIO.Text == "Error")
            {
                Results.IsCorrect = false;
                labelResult.ForeColor = System.Drawing.Color.Red;
                labelResult.Text = "Данные не получены";
            }
        }

        /// <summary>
        /// by ryzenvpn/vertyachikh: проверяет, что ФИО заполнено и состоит только из русских букв и пробелов, затем сохраняет итог проверки в Word.
        /// </summary>
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if (labelFIO.Text == null || labelFIO.Text.Length == 0 || labelFIO.Text == "" || labelFIO.Text == " ")
            {
                MessageBox.Show("Сначала необходимо получить данные");
            }
            else if (Regex.IsMatch(labelFIO.Text, @"^[А-Яа-я\s]+$"))
            {
                labelResult.ForeColor = System.Drawing.Color.Green;
                labelResult.Text = "ФИО корректно";
                Results.IsCorrect = true;
                ResultToWord.SaveResults();
            }
            else if (labelFIO.Text == "Error")
            {
                Results.IsCorrect = false;
                ResultToWord.SaveResults();
            }
            else
            {
                labelResult.ForeColor = System.Drawing.Color.Red;
                labelResult.Text = "ФИО содержит запрещённые символы";
                Results.IsCorrect = false;
                ResultToWord.SaveResults();
            }
        }
    }
}
