namespace Week4Database
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createButton = new System.Windows.Forms.Button();
            this.contactID = new System.Windows.Forms.TextBox();
            this.frstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.allowContact = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.createdDate = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(681, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(616, 554);
            this.dataGridView1.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(72, 511);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(147, 58);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // contactID
            // 
            this.contactID.Location = new System.Drawing.Point(170, 106);
            this.contactID.Name = "contactID";
            this.contactID.Size = new System.Drawing.Size(294, 26);
            this.contactID.TabIndex = 2;
            // 
            // frstName
            // 
            this.frstName.Location = new System.Drawing.Point(170, 174);
            this.frstName.Name = "frstName";
            this.frstName.Size = new System.Drawing.Size(294, 26);
            this.frstName.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(170, 247);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(294, 26);
            this.lastName.TabIndex = 4;
            // 
            // allowContact
            // 
            this.allowContact.AutoSize = true;
            this.allowContact.Location = new System.Drawing.Point(72, 308);
            this.allowContact.Name = "allowContact";
            this.allowContact.Size = new System.Drawing.Size(141, 24);
            this.allowContact.TabIndex = 5;
            this.allowContact.Text = "Allow Contact?";
            this.allowContact.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contact ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date Created";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(253, 511);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 58);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(72, 613);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(147, 58);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(253, 613);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(147, 58);
            this.btnDisplay.TabIndex = 15;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // createdDate
            // 
            this.createdDate.Location = new System.Drawing.Point(189, 433);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(294, 26);
            this.createdDate.TabIndex = 17;
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(189, 365);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(294, 26);
            this.DOB.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 841);
            this.Controls.Add(this.createdDate);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allowContact);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.frstName);
            this.Controls.Add(this.contactID);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox contactID;
        private System.Windows.Forms.TextBox frstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.CheckBox allowContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox createdDate;
        private System.Windows.Forms.TextBox DOB;
    }
}

