using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Word = Microsoft.Office.Interop.Word;

namespace Validator_Vertyachikh
{
    /// <summary>
    /// by ryzenvpn/vertyachikh: класс отвечает за перенос результатов проверки из приложения в Word-документ.
    /// </summary>
    public static class ResultToWord
    {
        /// <summary>
        /// by ryzenvpn/vertyachikh: открывает выбранный файл ТестКейс.docx, записывает статусы в закладки Result1 и Result2 и сохраняет документ.
        /// </summary>
        public static void SaveResults()
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Выберите файл ТестКейс.docx";
                dlg.FileName = "ТестКейс.docx";
                if (dlg.ShowDialog() != DialogResult.OK) return;

                Word.Application app = null;
                Word.Document doc = null;

                try
                {
                    app = new Word.Application();
                    doc = app.Documents.Open(dlg.FileName);
                    app.Visible = false;

                    // by ryzenvpn/vertyachikh: text1 хранит итог получения данных, text2 хранит итог проверки корректности ФИО.
                    string text1 = Results.IsGet ? "Успешно" : "Не успешно";
                    string text2 = Results.IsCorrect ? "Успешно" : "Не успешно";

                    // by ryzenvpn/vertyachikh: закладки Result1 и Result2 указывают места в Word-документе, куда записываются результаты.
                    var bookmark1 = doc.Bookmarks["Result1"];
                    var bookmark2 = doc.Bookmarks["Result2"];

                    var range1 = bookmark1.Range;
                    var range2 = bookmark2.Range;

                    // by ryzenvpn/vertyachikh: стартовые позиции нужны, чтобы восстановить закладки после замены текста.
                    int start1 = range1.Start;
                    int start2 = range2.Start;

                    range1.Text = text1;
                    range2.Text = text2;

                    doc.Bookmarks.Add("Result1", doc.Range(start1, start1 + text1.Length));
                    doc.Bookmarks.Add("Result2", doc.Range(start2, start2 + text2.Length));

                    doc.Save();
                    MessageBox.Show("Результаты записаны в документ!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    doc?.Close(false);
                    app?.Quit();
                    if (app != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                }
            }
        }
    }
}


