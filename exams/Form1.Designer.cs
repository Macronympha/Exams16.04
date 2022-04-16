
namespace exams
{
    partial class Form1
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
            this.TBGroup = new System.Windows.Forms.Label();
            this.TBPredmet = new System.Windows.Forms.Label();
            this.TBExam = new System.Windows.Forms.Label();
            this.maskedTBGroup = new System.Windows.Forms.MaskedTextBox();
            this.maskedTBPredmet = new System.Windows.Forms.MaskedTextBox();
            this.maskedTBExam = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // TBGroup
            // 
            this.TBGroup.AutoSize = true;
            this.TBGroup.Location = new System.Drawing.Point(238, 72);
            this.TBGroup.Name = "TBGroup";
            this.TBGroup.Size = new System.Drawing.Size(42, 13);
            this.TBGroup.TabIndex = 0;
            this.TBGroup.Text = "Группа";
            // 
            // TBPredmet
            // 
            this.TBPredmet.AutoSize = true;
            this.TBPredmet.Location = new System.Drawing.Point(228, 154);
            this.TBPredmet.Name = "TBPredmet";
            this.TBPredmet.Size = new System.Drawing.Size(52, 13);
            this.TBPredmet.TabIndex = 1;
            this.TBPredmet.Text = "Предмет";
            // 
            // TBExam
            // 
            this.TBExam.AutoSize = true;
            this.TBExam.Location = new System.Drawing.Point(183, 235);
            this.TBExam.Name = "TBExam";
            this.TBExam.Size = new System.Drawing.Size(97, 13);
            this.TBExam.TabIndex = 2;
            this.TBExam.Text = "Начало экзамена";
            // 
            // maskedTBGroup
            // 
            this.maskedTBGroup.Location = new System.Drawing.Point(297, 69);
            this.maskedTBGroup.Mask = "AA-AA.AAA";
            this.maskedTBGroup.Name = "maskedTBGroup";
            this.maskedTBGroup.Size = new System.Drawing.Size(232, 20);
            this.maskedTBGroup.TabIndex = 3;
            // 
            // maskedTBPredmet
            // 
            this.maskedTBPredmet.Location = new System.Drawing.Point(297, 151);
            this.maskedTBPredmet.Name = "maskedTBPredmet";
            this.maskedTBPredmet.Size = new System.Drawing.Size(232, 20);
            this.maskedTBPredmet.TabIndex = 4;
            this.maskedTBPredmet.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTBPredmet_MaskInputRejected);
            this.maskedTBPredmet.TextChanged += new System.EventHandler(this.maskedTBPredmet_TextChanged);
            this.maskedTBPredmet.Leave += new System.EventHandler(this.maskedTBPredmet_Leave);
            // 
            // maskedTBExam
            // 
            this.maskedTBExam.Location = new System.Drawing.Point(297, 235);
            this.maskedTBExam.Mask = "00/00/0000";
            this.maskedTBExam.Name = "maskedTBExam";
            this.maskedTBExam.Size = new System.Drawing.Size(232, 20);
            this.maskedTBExam.TabIndex = 5;
            this.maskedTBExam.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 310);
            this.Controls.Add(this.maskedTBExam);
            this.Controls.Add(this.maskedTBPredmet);
            this.Controls.Add(this.maskedTBGroup);
            this.Controls.Add(this.TBExam);
            this.Controls.Add(this.TBPredmet);
            this.Controls.Add(this.TBGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TBGroup;
        private System.Windows.Forms.Label TBPredmet;
        private System.Windows.Forms.Label TBExam;
        private System.Windows.Forms.MaskedTextBox maskedTBGroup;
        private System.Windows.Forms.MaskedTextBox maskedTBPredmet;
        private System.Windows.Forms.MaskedTextBox maskedTBExam;
    }
}

