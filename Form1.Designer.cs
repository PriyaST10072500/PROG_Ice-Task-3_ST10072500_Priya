namespace PROG_Ice_Task_3_ST10072500_Priya
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createBtn = new System.Windows.Forms.Button();
            this.processBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionIn = new System.Windows.Forms.RichTextBox();
            this.searchIn = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newDescriptionIn = new System.Windows.Forms.RichTextBox();
            this.modifyTicketNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(146, 198);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(56, 256);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(75, 23);
            this.processBtn.TabIndex = 3;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(56, 198);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(75, 23);
            this.undoBtn.TabIndex = 4;
            this.undoBtn.Text = "Undo";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Ticket Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search for Ticket via Number";
            // 
            // descriptionIn
            // 
            this.descriptionIn.Location = new System.Drawing.Point(56, 72);
            this.descriptionIn.Name = "descriptionIn";
            this.descriptionIn.Size = new System.Drawing.Size(178, 103);
            this.descriptionIn.TabIndex = 8;
            this.descriptionIn.Text = "";
            // 
            // searchIn
            // 
            this.searchIn.Location = new System.Drawing.Point(56, 345);
            this.searchIn.Name = "searchIn";
            this.searchIn.Size = new System.Drawing.Size(143, 20);
            this.searchIn.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(56, 395);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Ticket Number To Modify";
            // 
            // newDescriptionIn
            // 
            this.newDescriptionIn.Location = new System.Drawing.Point(420, 132);
            this.newDescriptionIn.Name = "newDescriptionIn";
            this.newDescriptionIn.Size = new System.Drawing.Size(178, 103);
            this.newDescriptionIn.TabIndex = 11;
            this.newDescriptionIn.Text = "";
            // 
            // modifyTicketNum
            // 
            this.modifyTicketNum.Location = new System.Drawing.Point(420, 64);
            this.modifyTicketNum.Name = "modifyTicketNum";
            this.modifyTicketNum.Size = new System.Drawing.Size(143, 20);
            this.modifyTicketNum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter New Tcket Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Display";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(420, 287);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(368, 121);
            this.listBox1.TabIndex = 15;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(305, 374);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 16;
            this.sortBtn.Text = "Sort Tickets";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(282, 287);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sort By Ticket Number";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(282, 335);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sort By Description";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(629, 212);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyBtn.TabIndex = 19;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modifyTicketNum);
            this.Controls.Add(this.newDescriptionIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.descriptionIn);
            this.Controls.Add(this.searchIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.createBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox descriptionIn;
        private System.Windows.Forms.TextBox searchIn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox newDescriptionIn;
        private System.Windows.Forms.TextBox modifyTicketNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button modifyBtn;
    }
}

