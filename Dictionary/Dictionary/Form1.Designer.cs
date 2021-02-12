namespace Dictionary
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
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.userAlreadyExist = new System.Windows.Forms.Label();
            this.heightText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.studentDatabase = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.userNotInDatabase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tryAgain = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(74, 268);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 36);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add user";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(74, 323);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(103, 36);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove user";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(74, 376);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(103, 36);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display users";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // userAlreadyExist
            // 
            this.userAlreadyExist.AutoSize = true;
            this.userAlreadyExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAlreadyExist.ForeColor = System.Drawing.Color.Red;
            this.userAlreadyExist.Location = new System.Drawing.Point(320, 353);
            this.userAlreadyExist.Name = "userAlreadyExist";
            this.userAlreadyExist.Size = new System.Drawing.Size(231, 20);
            this.userAlreadyExist.TabIndex = 3;
            this.userAlreadyExist.Text = "User is already in the database.";
            this.userAlreadyExist.Visible = false;
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(124, 151);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(119, 20);
            this.heightText.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(262, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 173);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(124, 114);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(119, 20);
            this.nameText.TabIndex = 6;
            // 
            // studentDatabase
            // 
            this.studentDatabase.AutoSize = true;
            this.studentDatabase.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDatabase.Location = new System.Drawing.Point(141, 9);
            this.studentDatabase.Name = "studentDatabase";
            this.studentDatabase.Size = new System.Drawing.Size(259, 40);
            this.studentDatabase.TabIndex = 7;
            this.studentDatabase.Text = "Student Database";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(51, 115);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 16);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Height (cm): ";
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLabel.Location = new System.Drawing.Point(12, 234);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(244, 16);
            this.actionLabel.TabIndex = 10;
            this.actionLabel.Text = "Choose one of the following action:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "made by Kevin Khuu.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(343, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "User has been added.";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "All users shown.";
            this.label3.Visible = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(221, 351);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(93, 22);
            this.status.TabIndex = 14;
            this.status.Text = "STATUS:";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userNotInDatabase
            // 
            this.userNotInDatabase.AutoSize = true;
            this.userNotInDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNotInDatabase.ForeColor = System.Drawing.Color.Red;
            this.userNotInDatabase.Location = new System.Drawing.Point(343, 353);
            this.userNotInDatabase.Name = "userNotInDatabase";
            this.userNotInDatabase.Size = new System.Drawing.Size(189, 20);
            this.userNotInDatabase.TabIndex = 15;
            this.userNotInDatabase.Text = "User isn\'t in the database";
            this.userNotInDatabase.Visible = false;
            this.userNotInDatabase.Click += new System.EventHandler(this.userNotInDatabase_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(343, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "User has been removed";
            this.label5.Visible = false;
            // 
            // tryAgain
            // 
            this.tryAgain.AllowDrop = true;
            this.tryAgain.AutoSize = true;
            this.tryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgain.ForeColor = System.Drawing.Color.Goldenrod;
            this.tryAgain.Location = new System.Drawing.Point(329, 342);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(192, 40);
            this.tryAgain.TabIndex = 17;
            this.tryAgain.Text = "Please enter a value \r\nin the appropriate textbox.";
            this.tryAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tryAgain.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "AVERAGE:";
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.average.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.average.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average.ForeColor = System.Drawing.SystemColors.Window;
            this.average.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.average.Location = new System.Drawing.Point(390, 284);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(68, 22);
            this.average.TabIndex = 19;
            this.average.Text = "average";
            this.average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.average.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 444);
            this.Controls.Add(this.average);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userNotInDatabase);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.studentDatabase);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.userAlreadyExist);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label userAlreadyExist;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label studentDatabase;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label userNotInDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tryAgain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label average;
    }
}

