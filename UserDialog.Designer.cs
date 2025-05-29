namespace LashaMurgvaLominadzeShraieri.Quiz3
{
    partial class UserDialog
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox NameTextBox;
        private TextBox LastnameTextBox;
        private TextBox EmailTextBox;
        private ComboBox GenderComboBox;
        private TextBox AgeTextBox;
        private Button DoneButton;

        private void InitializeComponent()
        {
            NameTextBox = new TextBox();
            LastnameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            GenderComboBox = new ComboBox();
            AgeTextBox = new TextBox();
            DoneButton = new Button();
            fnamelbl = new Label();
            lnamelbl = new Label();
            emaillbl = new Label();
            genderlbl = new Label();
            agelbl = new Label();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 30);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(200, 23);
            NameTextBox.TabIndex = 0;
            // 
            // LastnameTextBox
            // 
            LastnameTextBox.Location = new Point(12, 70);
            LastnameTextBox.Name = "LastnameTextBox";
            LastnameTextBox.Size = new Size(200, 23);
            LastnameTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(12, 110);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(200, 23);
            EmailTextBox.TabIndex = 2;
            // 
            // GenderComboBox
            // 
            GenderComboBox.Location = new Point(12, 150);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(200, 23);
            GenderComboBox.TabIndex = 3;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(12, 190);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(200, 23);
            AgeTextBox.TabIndex = 4;
            // 
            // DoneButton
            // 
            DoneButton.Location = new Point(12, 230);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(200, 30);
            DoneButton.TabIndex = 5;
            DoneButton.Text = "Done";
            DoneButton.Click += DoneButton_Click;
            // 
            // fnamelbl
            // 
            fnamelbl.AutoSize = true;
            fnamelbl.Location = new Point(12, 12);
            fnamelbl.Name = "fnamelbl";
            fnamelbl.Size = new Size(62, 15);
            fnamelbl.TabIndex = 6;
            fnamelbl.Text = "First name";
            // 
            // lnamelbl
            // 
            lnamelbl.AutoSize = true;
            lnamelbl.Location = new Point(12, 56);
            lnamelbl.Name = "lnamelbl";
            lnamelbl.Size = new Size(61, 15);
            lnamelbl.TabIndex = 7;
            lnamelbl.Text = "Last name";
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Location = new Point(12, 96);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(36, 15);
            emaillbl.TabIndex = 8;
            emaillbl.Text = "Email";
            // 
            // genderlbl
            // 
            genderlbl.AutoSize = true;
            genderlbl.Location = new Point(12, 132);
            genderlbl.Name = "genderlbl";
            genderlbl.Size = new Size(45, 15);
            genderlbl.TabIndex = 9;
            genderlbl.Text = "Gender";
            // 
            // agelbl
            // 
            agelbl.AutoSize = true;
            agelbl.Location = new Point(12, 176);
            agelbl.Name = "agelbl";
            agelbl.Size = new Size(28, 15);
            agelbl.TabIndex = 10;
            agelbl.Text = "Age";
            // 
            // UserDialog
            // 
            ClientSize = new Size(230, 280);
            Controls.Add(agelbl);
            Controls.Add(genderlbl);
            Controls.Add(emaillbl);
            Controls.Add(lnamelbl);
            Controls.Add(fnamelbl);
            Controls.Add(NameTextBox);
            Controls.Add(LastnameTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(GenderComboBox);
            Controls.Add(AgeTextBox);
            Controls.Add(DoneButton);
            Name = "UserDialog";
            Text = "User Dialog";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label fnamelbl;
        private Label lnamelbl;
        private Label emaillbl;
        private Label genderlbl;
        private Label agelbl;
    }
}
