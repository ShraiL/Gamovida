namespace LashaMurgvaLominadzeShraieri.Quiz3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBox;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;

        private void InitializeComponent()
        {
            listBox = new ListBox();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(14, 308);
            listBox.Name = "listBox";
            listBox.Size = new Size(886, 259);
            listBox.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(14, 168);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(86, 31);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(135, 168);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(86, 31);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit";
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(245, 168);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(86, 31);
            deleteBtn.TabIndex = 0;
            deleteBtn.Text = "Delete";
            deleteBtn.Click += deleteBtn_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(914, 600);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "User Management";
            ResumeLayout(false);
        }
    }
}
