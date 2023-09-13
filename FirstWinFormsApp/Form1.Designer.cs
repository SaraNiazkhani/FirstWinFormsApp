namespace FirstWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstNamelabel = new Label();
            label2 = new Label();
            LastNamelabel = new Label();
            Cellphonelabel = new Label();
            Nationalcodelabel = new Label();
            Genderlabel = new Label();
            Savebutton = new Button();
            FirstNametextBox = new TextBox();
            LastNametextBox = new TextBox();
            CellphonetextBox = new TextBox();
            NationalcodetextBox = new TextBox();
            GendercomboBox = new ComboBox();
            outPutTextBox = new TextBox();
            SuspendLayout();
            // 
            // FirstNamelabel
            // 
            FirstNamelabel.AutoSize = true;
            FirstNamelabel.Location = new Point(371, 46);
            FirstNamelabel.Name = "FirstNamelabel";
            FirstNamelabel.RightToLeft = RightToLeft.Yes;
            FirstNamelabel.Size = new Size(25, 14);
            FirstNamelabel.TabIndex = 0;
            FirstNamelabel.Text = "نام:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 89);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(0, 14);
            label2.TabIndex = 1;
            // 
            // LastNamelabel
            // 
            LastNamelabel.AutoSize = true;
            LastNamelabel.Location = new Point(320, 89);
            LastNamelabel.Name = "LastNamelabel";
            LastNamelabel.Size = new Size(76, 14);
            LastNamelabel.TabIndex = 2;
            LastNamelabel.Text = ":نام خانوادگی";
            LastNamelabel.Click += LastNamelabel_Click;
            // 
            // Cellphonelabel
            // 
            Cellphonelabel.AutoSize = true;
            Cellphonelabel.Location = new Point(298, 128);
            Cellphonelabel.Name = "Cellphonelabel";
            Cellphonelabel.RightToLeft = RightToLeft.Yes;
            Cellphonelabel.Size = new Size(103, 14);
            Cellphonelabel.TabIndex = 3;
            Cellphonelabel.Text = "شماره تلفن همراه:";
            Cellphonelabel.Click += Cellphonelabel_Click;
            // 
            // Nationalcodelabel
            // 
            Nationalcodelabel.AutoSize = true;
            Nationalcodelabel.Location = new Point(350, 172);
            Nationalcodelabel.Name = "Nationalcodelabel";
            Nationalcodelabel.RightToLeft = RightToLeft.Yes;
            Nationalcodelabel.Size = new Size(46, 14);
            Nationalcodelabel.TabIndex = 4;
            Nationalcodelabel.Text = "کدملی:";
            // 
            // Genderlabel
            // 
            Genderlabel.AutoSize = true;
            Genderlabel.Location = new Point(345, 216);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.RightToLeft = RightToLeft.Yes;
            Genderlabel.Size = new Size(51, 14);
            Genderlabel.TabIndex = 5;
            Genderlabel.Text = "جنسیت:";
            // 
            // Savebutton
            // 
            Savebutton.Location = new Point(12, 268);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(384, 61);
            Savebutton.TabIndex = 6;
            Savebutton.Text = "ثبت";
            Savebutton.UseVisualStyleBackColor = true;
            Savebutton.Click += Savebutton_Click;
            // 
            // FirstNametextBox
            // 
            FirstNametextBox.Location = new Point(110, 43);
            FirstNametextBox.Name = "FirstNametextBox";
            FirstNametextBox.Size = new Size(182, 22);
            FirstNametextBox.TabIndex = 7;
            // 
            // LastNametextBox
            // 
            LastNametextBox.Location = new Point(110, 81);
            LastNametextBox.Name = "LastNametextBox";
            LastNametextBox.Size = new Size(182, 22);
            LastNametextBox.TabIndex = 8;
            // 
            // CellphonetextBox
            // 
            CellphonetextBox.Location = new Point(110, 125);
            CellphonetextBox.Name = "CellphonetextBox";
            CellphonetextBox.Size = new Size(182, 22);
            CellphonetextBox.TabIndex = 9;
            CellphonetextBox.TextChanged += textBox3_TextChanged;
            // 
            // NationalcodetextBox
            // 
            NationalcodetextBox.Location = new Point(110, 169);
            NationalcodetextBox.Name = "NationalcodetextBox";
            NationalcodetextBox.Size = new Size(182, 22);
            NationalcodetextBox.TabIndex = 10;
            NationalcodetextBox.TextChanged += NationalcodetextBox_TextChanged;
            // 
            // GendercomboBox
            // 
            GendercomboBox.FormattingEnabled = true;
            GendercomboBox.Items.AddRange(new object[] { "زن", "مرد" });
            GendercomboBox.Location = new Point(215, 216);
            GendercomboBox.Name = "GendercomboBox";
            GendercomboBox.Size = new Size(77, 22);
            GendercomboBox.TabIndex = 11;
            GendercomboBox.SelectedIndexChanged += GendercomboBox_SelectedIndexChanged;
            // 
            // outPutTextBox
            // 
            outPutTextBox.Location = new Point(12, 369);
            outPutTextBox.Multiline = true;
            outPutTextBox.Name = "outPutTextBox";
            outPutTextBox.Size = new Size(384, 54);
            outPutTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 435);
            Controls.Add(outPutTextBox);
            Controls.Add(GendercomboBox);
            Controls.Add(NationalcodetextBox);
            Controls.Add(CellphonetextBox);
            Controls.Add(LastNametextBox);
            Controls.Add(FirstNametextBox);
            Controls.Add(Savebutton);
            Controls.Add(Genderlabel);
            Controls.Add(Nationalcodelabel);
            Controls.Add(Cellphonelabel);
            Controls.Add(LastNamelabel);
            Controls.Add(label2);
            Controls.Add(FirstNamelabel);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم ثبت نام";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNamelabel;
        private Label label2;
        private Label LastNamelabel;
        private Label Cellphonelabel;
        private Label Nationalcodelabel;
        private Label Genderlabel;
        private Button Savebutton;
        private TextBox FirstNametextBox;
        private TextBox LastNametextBox;
        private TextBox CellphonetextBox;
        private TextBox NationalcodetextBox;
        private ComboBox GendercomboBox;
        private TextBox outPutTextBox;
    }
}
