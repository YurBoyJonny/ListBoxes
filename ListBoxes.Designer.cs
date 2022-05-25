namespace ListBoxes
{
    partial class ListBoxes
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
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.lblNewList = new System.Windows.Forms.Button();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.lblSelectNumbers = new System.Windows.Forms.Label();
            this.lblEnterHeroNameAdd = new System.Windows.Forms.Label();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEnterHeroRemove = new System.Windows.Forms.Label();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpperCase = new System.Windows.Forms.Button();
            this.btnLowerCase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNumbers.Location = new System.Drawing.Point(44, 61);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(92, 23);
            this.btnNewNumbers.TabIndex = 0;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNumbers.Location = new System.Drawing.Point(142, 61);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(93, 23);
            this.btnSortNumbers.TabIndex = 1;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // lblNewList
            // 
            this.lblNewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewList.Location = new System.Drawing.Point(252, 61);
            this.lblNewList.Name = "lblNewList";
            this.lblNewList.Size = new System.Drawing.Size(89, 23);
            this.lblNewList.TabIndex = 2;
            this.lblNewList.Text = "New List";
            this.lblNewList.UseVisualStyleBackColor = true;
            this.lblNewList.Click += new System.EventHandler(this.lblNewList_Click);
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortHeroes.Location = new System.Drawing.Point(347, 61);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(88, 23);
            this.btnSortHeroes.TabIndex = 3;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lstNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(45, 90);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(190, 106);
            this.lstNumbers.TabIndex = 4;
            // 
            // lstHeroes
            // 
            this.lstHeroes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lstHeroes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHeroes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(252, 90);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(183, 106);
            this.lstHeroes.TabIndex = 5;
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(40, 34);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(80, 20);
            this.lblNumbers.TabIndex = 6;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroes.Location = new System.Drawing.Point(248, 34);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(67, 20);
            this.lblHeroes.TabIndex = 7;
            this.lblHeroes.Text = "Heroes";
            // 
            // lblSelectNumbers
            // 
            this.lblSelectNumbers.AutoSize = true;
            this.lblSelectNumbers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSelectNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectNumbers.Location = new System.Drawing.Point(42, 201);
            this.lblSelectNumbers.Name = "lblSelectNumbers";
            this.lblSelectNumbers.Size = new System.Drawing.Size(193, 16);
            this.lblSelectNumbers.TabIndex = 8;
            this.lblSelectNumbers.Text = "Select a number to remove";
            // 
            // lblEnterHeroNameAdd
            // 
            this.lblEnterHeroNameAdd.AutoSize = true;
            this.lblEnterHeroNameAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEnterHeroNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterHeroNameAdd.Location = new System.Drawing.Point(249, 201);
            this.lblEnterHeroNameAdd.Name = "lblEnterHeroNameAdd";
            this.lblEnterHeroNameAdd.Size = new System.Drawing.Size(186, 16);
            this.lblEnterHeroNameAdd.TabIndex = 9;
            this.lblEnterHeroNameAdd.Text = "Enter a hero name to add:";
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumber.Location = new System.Drawing.Point(45, 220);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveNumber.TabIndex = 10;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(142, 220);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveAllNumbers.TabIndex = 11;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            this.btnRemoveAllNumbers.Click += new System.EventHandler(this.btnRemoveAllNumbers_Click);
            // 
            // btnAddHero
            // 
            this.btnAddHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHero.Location = new System.Drawing.Point(374, 220);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(61, 23);
            this.btnAddHero.TabIndex = 12;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHero.Location = new System.Drawing.Point(347, 262);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(88, 23);
            this.btnRemoveHero.TabIndex = 13;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(17, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 18);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status";
            // 
            // lblEnterHeroRemove
            // 
            this.lblEnterHeroRemove.AutoSize = true;
            this.lblEnterHeroRemove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEnterHeroRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterHeroRemove.Location = new System.Drawing.Point(249, 246);
            this.lblEnterHeroRemove.Name = "lblEnterHeroRemove";
            this.lblEnterHeroRemove.Size = new System.Drawing.Size(211, 16);
            this.lblEnterHeroRemove.TabIndex = 15;
            this.lblEnterHeroRemove.Text = "Enter a hero name to remove:";
            // 
            // txtAddHero
            // 
            this.txtAddHero.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAddHero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddHero.Location = new System.Drawing.Point(252, 220);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(116, 20);
            this.txtAddHero.TabIndex = 16;
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtRemoveHero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemoveHero.Location = new System.Drawing.Point(252, 265);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(89, 20);
            this.txtRemoveHero.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 426);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(45, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 45);
            this.panel1.TabIndex = 20;
            // 
            // btnUpperCase
            // 
            this.btnUpperCase.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpperCase.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpperCase.Location = new System.Drawing.Point(450, 90);
            this.btnUpperCase.Name = "btnUpperCase";
            this.btnUpperCase.Size = new System.Drawing.Size(91, 49);
            this.btnUpperCase.TabIndex = 21;
            this.btnUpperCase.Text = "Upper Case";
            this.btnUpperCase.UseVisualStyleBackColor = false;
            // 
            // btnLowerCase
            // 
            this.btnLowerCase.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowerCase.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLowerCase.Location = new System.Drawing.Point(450, 145);
            this.btnLowerCase.Name = "btnLowerCase";
            this.btnLowerCase.Size = new System.Drawing.Size(91, 51);
            this.btnLowerCase.TabIndex = 22;
            this.btnLowerCase.Text = "Lower Case";
            this.btnLowerCase.UseVisualStyleBackColor = false;
            this.btnLowerCase.Click += new System.EventHandler(this.btnLowerCase_Click);
            // 
            // ListBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLowerCase);
            this.Controls.Add(this.btnUpperCase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.lblEnterHeroRemove);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.lblEnterHeroNameAdd);
            this.Controls.Add(this.lblSelectNumbers);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.lblNewList);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListBoxes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button lblNewList;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.Label lblSelectNumbers;
        private System.Windows.Forms.Label lblEnterHeroNameAdd;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEnterHeroRemove;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpperCase;
        private System.Windows.Forms.Button btnLowerCase;
    }
}

