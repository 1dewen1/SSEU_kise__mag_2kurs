namespace student
{
    partial class FormStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelNstud = new System.Windows.Forms.Label();
            this.numericUpDownKurs = new System.Windows.Forms.NumericUpDown();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.radioButtonBudget = new System.Windows.Forms.RadioButton();
            this.textBoxNstud = new System.Windows.Forms.TextBox();
            this.labelGruppa = new System.Windows.Forms.Label();
            this.labelKurs = new System.Windows.Forms.Label();
            this.texGruppa = new System.Windows.Forms.TextBox();
            this.radioButtonCommerce = new System.Windows.Forms.RadioButton();
            this.labelBudget = new System.Windows.Forms.Label();
            this.textBoxStudentInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(8, 17);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // labelNstud
            // 
            this.labelNstud.AutoSize = true;
            this.labelNstud.Location = new System.Drawing.Point(8, 44);
            this.labelNstud.Name = "labelNstud";
            this.labelNstud.Size = new System.Drawing.Size(133, 13);
            this.labelNstud.TabIndex = 1;
            this.labelNstud.Text = "№ студенческого билета";
            // 
            // numericUpDownKurs
            // 
            this.numericUpDownKurs.Location = new System.Drawing.Point(344, 39);
            this.numericUpDownKurs.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownKurs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.Name = "numericUpDownKurs";
            this.numericUpDownKurs.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownKurs.TabIndex = 2;
            this.numericUpDownKurs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.ValueChanged += new System.EventHandler(this.numericUpDownKurs_ValueChanged);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(147, 10);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(381, 20);
            this.textBoxFIO.TabIndex = 3;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // radioButtonBudget
            // 
            this.radioButtonBudget.AutoSize = true;
            this.radioButtonBudget.Checked = true;
            this.radioButtonBudget.Location = new System.Drawing.Point(147, 78);
            this.radioButtonBudget.Name = "radioButtonBudget";
            this.radioButtonBudget.Size = new System.Drawing.Size(121, 17);
            this.radioButtonBudget.TabIndex = 4;
            this.radioButtonBudget.TabStop = true;
            this.radioButtonBudget.Text = "бюджетной основе";
            this.radioButtonBudget.UseVisualStyleBackColor = true;
            this.radioButtonBudget.CheckedChanged += new System.EventHandler(this.radioButtonBudget_CheckedChanged);
            // 
            // textBoxNstud
            // 
            this.textBoxNstud.Location = new System.Drawing.Point(147, 39);
            this.textBoxNstud.MaxLength = 6;
            this.textBoxNstud.Name = "textBoxNstud";
            this.textBoxNstud.Size = new System.Drawing.Size(130, 20);
            this.textBoxNstud.TabIndex = 5;
            this.textBoxNstud.Text = "000000";
            this.textBoxNstud.TextChanged += new System.EventHandler(this.textBoxNstud_TextChanged);
            // 
            // labelGruppa
            // 
            this.labelGruppa.AutoSize = true;
            this.labelGruppa.Location = new System.Drawing.Point(416, 44);
            this.labelGruppa.Name = "labelGruppa";
            this.labelGruppa.Size = new System.Drawing.Size(42, 13);
            this.labelGruppa.TabIndex = 6;
            this.labelGruppa.Text = "Группа";
            // 
            // labelKurs
            // 
            this.labelKurs.AutoSize = true;
            this.labelKurs.Location = new System.Drawing.Point(307, 46);
            this.labelKurs.Name = "labelKurs";
            this.labelKurs.Size = new System.Drawing.Size(31, 13);
            this.labelKurs.TabIndex = 7;
            this.labelKurs.Text = "Курс";
            // 
            // texGruppa
            // 
            this.texGruppa.Location = new System.Drawing.Point(464, 39);
            this.texGruppa.Name = "texGruppa";
            this.texGruppa.Size = new System.Drawing.Size(64, 20);
            this.texGruppa.TabIndex = 8;
            this.texGruppa.TextChanged += new System.EventHandler(this.texGruppa_TextChanged);
            // 
            // radioButtonCommerce
            // 
            this.radioButtonCommerce.AutoSize = true;
            this.radioButtonCommerce.Location = new System.Drawing.Point(147, 101);
            this.radioButtonCommerce.Name = "radioButtonCommerce";
            this.radioButtonCommerce.Size = new System.Drawing.Size(139, 17);
            this.radioButtonCommerce.TabIndex = 9;
            this.radioButtonCommerce.Text = "коммерческой основе";
            this.radioButtonCommerce.UseVisualStyleBackColor = true;
            // 
            // labelBudget
            // 
            this.labelBudget.AutoSize = true;
            this.labelBudget.Location = new System.Drawing.Point(66, 78);
            this.labelBudget.Name = "labelBudget";
            this.labelBudget.Size = new System.Drawing.Size(75, 13);
            this.labelBudget.TabIndex = 10;
            this.labelBudget.Text = "Обучается на";
            // 
            // textBoxStudentInfo
            // 
            this.textBoxStudentInfo.Location = new System.Drawing.Point(15, 138);
            this.textBoxStudentInfo.Multiline = true;
            this.textBoxStudentInfo.Name = "textBoxStudentInfo";
            this.textBoxStudentInfo.ReadOnly = true;
            this.textBoxStudentInfo.Size = new System.Drawing.Size(513, 154);
            this.textBoxStudentInfo.TabIndex = 11;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 309);
            this.Controls.Add(this.textBoxStudentInfo);
            this.Controls.Add(this.labelBudget);
            this.Controls.Add(this.radioButtonCommerce);
            this.Controls.Add(this.texGruppa);
            this.Controls.Add(this.labelKurs);
            this.Controls.Add(this.labelGruppa);
            this.Controls.Add(this.textBoxNstud);
            this.Controls.Add(this.radioButtonBudget);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.numericUpDownKurs);
            this.Controls.Add(this.labelNstud);
            this.Controls.Add(this.labelFIO);
            this.Name = "FormStudent";
            this.Text = "Студент";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelNstud;
        private System.Windows.Forms.NumericUpDown numericUpDownKurs;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.RadioButton radioButtonBudget;
        private System.Windows.Forms.TextBox textBoxNstud;
        private System.Windows.Forms.Label labelGruppa;
        private System.Windows.Forms.Label labelKurs;
        private System.Windows.Forms.TextBox texGruppa;
        private System.Windows.Forms.RadioButton radioButtonCommerce;
        private System.Windows.Forms.Label labelBudget;
        private System.Windows.Forms.TextBox textBoxStudentInfo;
    }
}

