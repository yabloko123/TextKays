namespace Validator_Vertyachikh
{
    /// <summary>
    /// by ryzenvpn/vertyachikh: часть класса Form1, созданная дизайнером WinForms для хранения элементов интерфейса.
    /// </summary>
    partial class Form1
    {
        /// <summary>
        /// by ryzenvpn/vertyachikh: контейнер хранит компоненты формы, чтобы их можно было корректно освободить при закрытии.
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// by ryzenvpn/vertyachikh: освобождает компоненты формы при закрытии окна.
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// by ryzenvpn/vertyachikh: создает кнопки и подписи формы, задает их размеры, текст и события.
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGet
            // 
            this.buttonGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGet.Location = new System.Drawing.Point(80, 108);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(555, 87);
            this.buttonGet.TabIndex = 0;
            this.buttonGet.Text = "Получить данные";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWrite.Location = new System.Drawing.Point(80, 335);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(555, 87);
            this.buttonWrite.TabIndex = 1;
            this.buttonWrite.Text = "Записать результат";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(688, 121);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(0, 63);
            this.labelFIO.TabIndex = 2;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(688, 348);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 63);
            this.labelResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1928, 512);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonGet);
            this.Name = "Form1";
            this.Text = "Акимов Данила RyzenVPN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// by ryzenvpn/vertyachikh: кнопка запускает получение ФИО из API.
        /// </summary>
        private System.Windows.Forms.Button buttonGet;

        /// <summary>
        /// by ryzenvpn/vertyachikh: кнопка запускает проверку ФИО и запись результата в Word-документ.
        /// </summary>
        private System.Windows.Forms.Button buttonWrite;

        /// <summary>
        /// by ryzenvpn/vertyachikh: метка отображает ФИО, полученное от сервиса.
        /// </summary>
        private System.Windows.Forms.Label labelFIO;

        /// <summary>
        /// by ryzenvpn/vertyachikh: метка отображает текстовый итог проверки ФИО для пользователя.
        /// </summary>
        private System.Windows.Forms.Label labelResult;
    }
}

