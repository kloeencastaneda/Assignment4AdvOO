namespace Assignment4AdvOO
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
            chkBox = new CheckBox();
            contactID = new TextBox();
            firstName = new TextBox();
            lastName = new TextBox();
            DOB = new DateTimePicker();
            createdDate = new DateTimePicker();
            frstName = new Label();
            lstName = new Label();
            dateOfBirth = new Label();
            createDate = new Label();
            conID = new Label();
            dataGridView1 = new DataGridView();
            saveBtn = new Button();
            upBtn = new Button();
            delBtn = new Button();
            creBtn = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // chkBox
            // 
            chkBox.AutoSize = true;
            chkBox.BackColor = SystemColors.Window;
            chkBox.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            chkBox.FlatAppearance.CheckedBackColor = Color.White;
            chkBox.FlatStyle = FlatStyle.System;
            chkBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBox.Location = new Point(149, 222);
            chkBox.Name = "chkBox";
            chkBox.Size = new Size(128, 21);
            chkBox.TabIndex = 0;
            chkBox.Text = "Allow Contact?";
            chkBox.UseVisualStyleBackColor = false;
            chkBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // contactID
            // 
            contactID.BorderStyle = BorderStyle.None;
            contactID.Location = new Point(149, 32);
            contactID.Name = "contactID";
            contactID.Size = new Size(213, 16);
            contactID.TabIndex = 1;
            // 
            // firstName
            // 
            firstName.BorderStyle = BorderStyle.None;
            firstName.Location = new Point(149, 79);
            firstName.Name = "firstName";
            firstName.Size = new Size(213, 16);
            firstName.TabIndex = 2;
            // 
            // lastName
            // 
            lastName.BorderStyle = BorderStyle.None;
            lastName.Location = new Point(149, 125);
            lastName.Name = "lastName";
            lastName.Size = new Size(213, 16);
            lastName.TabIndex = 3;
            // 
            // DOB
            // 
            DOB.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOB.Format = DateTimePickerFormat.Short;
            DOB.Location = new Point(149, 172);
            DOB.Name = "DOB";
            DOB.Size = new Size(213, 23);
            DOB.TabIndex = 6;
            // 
            // createdDate
            // 
            createdDate.CalendarFont = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createdDate.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createdDate.Format = DateTimePickerFormat.Short;
            createdDate.Location = new Point(149, 263);
            createdDate.Name = "createdDate";
            createdDate.Size = new Size(213, 23);
            createdDate.TabIndex = 7;
            // 
            // frstName
            // 
            frstName.AutoSize = true;
            frstName.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            frstName.Location = new Point(35, 79);
            frstName.Name = "frstName";
            frstName.Size = new Size(75, 16);
            frstName.TabIndex = 8;
            frstName.Text = "First Name";
            frstName.Click += frstName_Click;
            // 
            // lstName
            // 
            lstName.AutoSize = true;
            lstName.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstName.Location = new Point(36, 125);
            lstName.Name = "lstName";
            lstName.Size = new Size(74, 16);
            lstName.TabIndex = 9;
            lstName.Text = "Last Name";
            // 
            // dateOfBirth
            // 
            dateOfBirth.AutoSize = true;
            dateOfBirth.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateOfBirth.Location = new Point(36, 177);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(88, 16);
            dateOfBirth.TabIndex = 10;
            dateOfBirth.Text = "Date Of Birth";
            // 
            // createDate
            // 
            createDate.AutoSize = true;
            createDate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createDate.Location = new Point(36, 268);
            createDate.Name = "createDate";
            createDate.Size = new Size(90, 16);
            createDate.TabIndex = 11;
            createDate.Text = "Date Created";
            // 
            // conID
            // 
            conID.AutoSize = true;
            conID.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            conID.Location = new Point(35, 32);
            conID.Name = "conID";
            conID.Size = new Size(72, 16);
            conID.TabIndex = 12;
            conID.Text = "Contact ID";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(389, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(387, 365);
            dataGridView1.TabIndex = 13;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.MediumSlateBlue;
            saveBtn.BackgroundImageLayout = ImageLayout.None;
            saveBtn.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(261, 389);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(82, 36);
            saveBtn.TabIndex = 14;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            // 
            // upBtn
            // 
            upBtn.BackColor = Color.SlateBlue;
            upBtn.FlatAppearance.BorderColor = Color.SlateBlue;
            upBtn.FlatStyle = FlatStyle.Flat;
            upBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upBtn.ForeColor = SystemColors.ControlLightLight;
            upBtn.Location = new Point(149, 318);
            upBtn.Name = "upBtn";
            upBtn.Size = new Size(78, 36);
            upBtn.TabIndex = 15;
            upBtn.Text = "Update";
            upBtn.UseVisualStyleBackColor = false;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.SlateBlue;
            delBtn.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            delBtn.FlatStyle = FlatStyle.Flat;
            delBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delBtn.ForeColor = SystemColors.Control;
            delBtn.Location = new Point(261, 318);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(82, 36);
            delBtn.TabIndex = 16;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = false;
            // 
            // creBtn
            // 
            creBtn.BackColor = Color.SlateBlue;
            creBtn.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            creBtn.FlatStyle = FlatStyle.Flat;
            creBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creBtn.ForeColor = SystemColors.HighlightText;
            creBtn.Location = new Point(36, 318);
            creBtn.Name = "creBtn";
            creBtn.Size = new Size(78, 36);
            creBtn.TabIndex = 17;
            creBtn.Text = "Create";
            creBtn.UseVisualStyleBackColor = false;
            creBtn.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 192, 255);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(404, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 32);
            textBox1.TabIndex = 18;
            textBox1.Text = "Conact Info";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(creBtn);
            Controls.Add(delBtn);
            Controls.Add(upBtn);
            Controls.Add(saveBtn);
            Controls.Add(dataGridView1);
            Controls.Add(conID);
            Controls.Add(createDate);
            Controls.Add(dateOfBirth);
            Controls.Add(lstName);
            Controls.Add(frstName);
            Controls.Add(createdDate);
            Controls.Add(DOB);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(contactID);
            Controls.Add(chkBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkBox;
        private TextBox contactID;
        private TextBox firstName;
        private TextBox lastName;
        private DateTimePicker DOB;
        private DateTimePicker createdDate;
        private Label frstName;
        private Label lstName;
        private Label dateOfBirth;
        private Label createDate;
        private Label conID;
        private DataGridView dataGridView1;
        private Button saveBtn;
        private Button upBtn;
        private Button delBtn;
        private Button creBtn;
        private TextBox textBox1;
    }
}
