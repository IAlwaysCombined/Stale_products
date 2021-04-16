namespace Stale_products
{
    partial class ChangeYear
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageYar = new System.Windows.Forms.TabPage();
            this.buttonCreateSchedule = new System.Windows.Forms.Button();
            this.textBoxYaer = new System.Windows.Forms.TextBox();
            this.labelYaer = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxChangeProductYear = new System.Windows.Forms.ComboBox();
            this.tabPageQuarter = new System.Windows.Forms.TabPage();
            this.numericUpDownQuartal = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateScheduleQuartal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxChangeProducQuartal = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPageYar.SuspendLayout();
            this.tabPageQuarter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuartal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageYar);
            this.tabControl.Controls.Add(this.tabPageQuarter);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(778, 242);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageYar
            // 
            this.tabPageYar.Controls.Add(this.buttonCreateSchedule);
            this.tabPageYar.Controls.Add(this.textBoxYaer);
            this.tabPageYar.Controls.Add(this.labelYaer);
            this.tabPageYar.Controls.Add(this.labelProduct);
            this.tabPageYar.Controls.Add(this.comboBoxChangeProductYear);
            this.tabPageYar.Location = new System.Drawing.Point(4, 22);
            this.tabPageYar.Name = "tabPageYar";
            this.tabPageYar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYar.Size = new System.Drawing.Size(770, 216);
            this.tabPageYar.TabIndex = 0;
            this.tabPageYar.Text = "Год";
            this.tabPageYar.UseVisualStyleBackColor = true;
            // 
            // buttonCreateSchedule
            // 
            this.buttonCreateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonCreateSchedule.Location = new System.Drawing.Point(11, 120);
            this.buttonCreateSchedule.Name = "buttonCreateSchedule";
            this.buttonCreateSchedule.Size = new System.Drawing.Size(753, 40);
            this.buttonCreateSchedule.TabIndex = 4;
            this.buttonCreateSchedule.Text = "Построить график";
            this.buttonCreateSchedule.UseVisualStyleBackColor = true;
            this.buttonCreateSchedule.Click += new System.EventHandler(this.buttonCreateSchedule_Click);
            // 
            // textBoxYaer
            // 
            this.textBoxYaer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.textBoxYaer.Location = new System.Drawing.Point(518, 34);
            this.textBoxYaer.Name = "textBoxYaer";
            this.textBoxYaer.Size = new System.Drawing.Size(246, 32);
            this.textBoxYaer.TabIndex = 3;
            // 
            // labelYaer
            // 
            this.labelYaer.AutoSize = true;
            this.labelYaer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelYaer.Location = new System.Drawing.Point(463, 32);
            this.labelYaer.Name = "labelYaer";
            this.labelYaer.Size = new System.Drawing.Size(49, 26);
            this.labelYaer.TabIndex = 2;
            this.labelYaer.Text = "Год";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelProduct.Location = new System.Drawing.Point(6, 32);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(72, 26);
            this.labelProduct.TabIndex = 1;
            this.labelProduct.Text = "Товар";
            // 
            // comboBoxChangeProductYear
            // 
            this.comboBoxChangeProductYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.comboBoxChangeProductYear.FormattingEnabled = true;
            this.comboBoxChangeProductYear.Location = new System.Drawing.Point(84, 32);
            this.comboBoxChangeProductYear.Name = "comboBoxChangeProductYear";
            this.comboBoxChangeProductYear.Size = new System.Drawing.Size(373, 34);
            this.comboBoxChangeProductYear.TabIndex = 0;
            // 
            // tabPageQuarter
            // 
            this.tabPageQuarter.Controls.Add(this.numericUpDownQuartal);
            this.tabPageQuarter.Controls.Add(this.buttonCreateScheduleQuartal);
            this.tabPageQuarter.Controls.Add(this.label1);
            this.tabPageQuarter.Controls.Add(this.label2);
            this.tabPageQuarter.Controls.Add(this.comboBoxChangeProducQuartal);
            this.tabPageQuarter.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuarter.Name = "tabPageQuarter";
            this.tabPageQuarter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuarter.Size = new System.Drawing.Size(770, 216);
            this.tabPageQuarter.TabIndex = 1;
            this.tabPageQuarter.Text = "Квартал";
            this.tabPageQuarter.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuartal
            // 
            this.numericUpDownQuartal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.numericUpDownQuartal.Location = new System.Drawing.Point(567, 45);
            this.numericUpDownQuartal.Name = "numericUpDownQuartal";
            this.numericUpDownQuartal.Size = new System.Drawing.Size(197, 32);
            this.numericUpDownQuartal.TabIndex = 10;
            // 
            // buttonCreateScheduleQuartal
            // 
            this.buttonCreateScheduleQuartal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonCreateScheduleQuartal.Location = new System.Drawing.Point(11, 132);
            this.buttonCreateScheduleQuartal.Name = "buttonCreateScheduleQuartal";
            this.buttonCreateScheduleQuartal.Size = new System.Drawing.Size(753, 40);
            this.buttonCreateScheduleQuartal.TabIndex = 9;
            this.buttonCreateScheduleQuartal.Text = "Построить график";
            this.buttonCreateScheduleQuartal.UseVisualStyleBackColor = true;
            this.buttonCreateScheduleQuartal.Click += new System.EventHandler(this.buttonCreateScheduleQuartal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(463, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Квартал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Товар";
            // 
            // comboBoxChangeProducQuartal
            // 
            this.comboBoxChangeProducQuartal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.comboBoxChangeProducQuartal.FormattingEnabled = true;
            this.comboBoxChangeProducQuartal.Location = new System.Drawing.Point(84, 44);
            this.comboBoxChangeProducQuartal.Name = "comboBoxChangeProducQuartal";
            this.comboBoxChangeProducQuartal.Size = new System.Drawing.Size(373, 34);
            this.comboBoxChangeProducQuartal.TabIndex = 5;
            // 
            // ChangeYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 266);
            this.Controls.Add(this.tabControl);
            this.Name = "ChangeYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор расчета";
            this.Load += new System.EventHandler(this.ChangYear_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageYar.ResumeLayout(false);
            this.tabPageYar.PerformLayout();
            this.tabPageQuarter.ResumeLayout(false);
            this.tabPageQuarter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuartal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageYar;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxChangeProductYear;
        private System.Windows.Forms.TabPage tabPageQuarter;
        private System.Windows.Forms.TextBox textBoxYaer;
        private System.Windows.Forms.Label labelYaer;
        private System.Windows.Forms.Button buttonCreateSchedule;
        private System.Windows.Forms.NumericUpDown numericUpDownQuartal;
        private System.Windows.Forms.Button buttonCreateScheduleQuartal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxChangeProducQuartal;
    }
}

