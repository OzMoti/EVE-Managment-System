
namespace EVE_Managment_System
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.customer_textbox = new System.Windows.Forms.TextBox();
            this.pnum = new System.Windows.Forms.NumericUpDown();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.radioButtonEX = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonFR4 = new System.Windows.Forms.RadioButton();
            this.RadioButtonCEM1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAL = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ppnum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pnum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppnum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zleceniodawca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data otrzymania zamówienia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(107, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Termin realizacji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(98, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ilość  zamówiona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(160, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Priorytet";
            // 
            // date_start
            // 
            this.date_start.Location = new System.Drawing.Point(273, 127);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(253, 23);
            this.date_start.TabIndex = 9;
            this.date_start.ValueChanged += new System.EventHandler(this.date_start_ValueChanged);
            // 
            // date_end
            // 
            this.date_end.Location = new System.Drawing.Point(273, 185);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(253, 23);
            this.date_end.TabIndex = 10;
            this.date_end.ValueChanged += new System.EventHandler(this.date_end_ValueChanged);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(272, 23);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(249, 23);
            this.name_textbox.TabIndex = 11;
            // 
            // customer_textbox
            // 
            this.customer_textbox.Location = new System.Drawing.Point(273, 74);
            this.customer_textbox.Name = "customer_textbox";
            this.customer_textbox.Size = new System.Drawing.Size(249, 23);
            this.customer_textbox.TabIndex = 12;
            // 
            // pnum
            // 
            this.pnum.Location = new System.Drawing.Point(272, 234);
            this.pnum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(47, 23);
            this.pnum.TabIndex = 13;
            this.pnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButtonN
            // 
            this.radioButtonN.AutoCheck = false;
            this.radioButtonN.AutoSize = true;
            this.radioButtonN.Checked = true;
            this.radioButtonN.Location = new System.Drawing.Point(273, 328);
            this.radioButtonN.Name = "radioButtonN";
            this.radioButtonN.Size = new System.Drawing.Size(34, 19);
            this.radioButtonN.TabIndex = 14;
            this.radioButtonN.Text = "N";
            this.radioButtonN.UseVisualStyleBackColor = true;
            this.radioButtonN.Click += new System.EventHandler(this.radioButtonN_CheckedChanged);
            // 
            // radioButtonEX
            // 
            this.radioButtonEX.AutoCheck = false;
            this.radioButtonEX.AutoSize = true;
            this.radioButtonEX.Location = new System.Drawing.Point(330, 328);
            this.radioButtonEX.Name = "radioButtonEX";
            this.radioButtonEX.Size = new System.Drawing.Size(38, 19);
            this.radioButtonEX.TabIndex = 15;
            this.radioButtonEX.Text = "EX";
            this.radioButtonEX.UseVisualStyleBackColor = true;
            this.radioButtonEX.Click += new System.EventHandler(this.radioButtonEX_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(140, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Rodzaj PCB";
            // 
            // radioButtonFR4
            // 
            this.radioButtonFR4.AutoSize = true;
            this.radioButtonFR4.Checked = true;
            this.radioButtonFR4.Location = new System.Drawing.Point(272, 368);
            this.radioButtonFR4.Name = "radioButtonFR4";
            this.radioButtonFR4.Size = new System.Drawing.Size(44, 19);
            this.radioButtonFR4.TabIndex = 17;
            this.radioButtonFR4.TabStop = true;
            this.radioButtonFR4.Text = "FR4";
            this.radioButtonFR4.UseVisualStyleBackColor = true;
            this.radioButtonFR4.CheckedChanged += new System.EventHandler(this.radioButtonFR4_CheckedChanged);
            // 
            // RadioButtonCEM1
            // 
            this.RadioButtonCEM1.AutoSize = true;
            this.RadioButtonCEM1.Location = new System.Drawing.Point(330, 368);
            this.RadioButtonCEM1.Name = "RadioButtonCEM1";
            this.RadioButtonCEM1.Size = new System.Drawing.Size(50, 19);
            this.RadioButtonCEM1.TabIndex = 18;
            this.RadioButtonCEM1.Text = "CEM";
            this.RadioButtonCEM1.UseVisualStyleBackColor = true;
            this.RadioButtonCEM1.CheckedChanged += new System.EventHandler(this.RadioButtonCEM1_CheckedChanged);
            // 
            // radioButtonAL
            // 
            this.radioButtonAL.AutoSize = true;
            this.radioButtonAL.Location = new System.Drawing.Point(404, 368);
            this.radioButtonAL.Name = "radioButtonAL";
            this.radioButtonAL.Size = new System.Drawing.Size(39, 19);
            this.radioButtonAL.TabIndex = 19;
            this.radioButtonAL.Text = "AL";
            this.radioButtonAL.UseVisualStyleBackColor = true;
            this.radioButtonAL.CheckedChanged += new System.EventHandler(this.radioButtonAL_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ppnum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.radioButtonAL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.RadioButtonCEM1);
            this.groupBox1.Controls.Add(this.radioButtonFR4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButtonEX);
            this.groupBox1.Controls.Add(this.radioButtonN);
            this.groupBox1.Controls.Add(this.pnum);
            this.groupBox1.Controls.Add(this.customer_textbox);
            this.groupBox1.Controls.Add(this.name_textbox);
            this.groupBox1.Controls.Add(this.date_end);
            this.groupBox1.Controls.Add(this.date_start);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 464);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nowe zamówienie";
            // 
            // ppnum
            // 
            this.ppnum.Location = new System.Drawing.Point(272, 275);
            this.ppnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ppnum.Name = "ppnum";
            this.ppnum.Size = new System.Drawing.Size(47, 23);
            this.ppnum.TabIndex = 23;
            this.ppnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(62, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ilość sztuk na panelu ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(577, 486);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Nowe zamówienie";
            ((System.ComponentModel.ISupportInitialize)(this.pnum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppnum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox customer_textbox;
        private System.Windows.Forms.NumericUpDown pnum;
        private System.Windows.Forms.RadioButton radioButtonN;
        private System.Windows.Forms.RadioButton radioButtonEX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonFR4;
        private System.Windows.Forms.RadioButton RadioButtonCEM1;
        private System.Windows.Forms.RadioButton radioButtonAL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown ppnum;
        private System.Windows.Forms.Label label8;
    }
}