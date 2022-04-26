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
            this.SuspendLayout();
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNumbers.Location = new System.Drawing.Point(16, 36);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnNewNumbers.TabIndex = 0;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNumbers.Location = new System.Drawing.Point(97, 36);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnSortNumbers.TabIndex = 1;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // lblNewList
            // 
            this.lblNewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewList.Location = new System.Drawing.Point(219, 36);
            this.lblNewList.Name = "lblNewList";
            this.lblNewList.Size = new System.Drawing.Size(75, 23);
            this.lblNewList.TabIndex = 2;
            this.lblNewList.Text = "New List";
            this.lblNewList.UseVisualStyleBackColor = true;
            this.lblNewList.Click += new System.EventHandler(this.lblNewList_Click);
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortHeroes.Location = new System.Drawing.Point(300, 36);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(75, 23);
            this.btnSortHeroes.TabIndex = 3;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(16, 65);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(156, 108);
            this.lstNumbers.TabIndex = 4;
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(219, 65);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(156, 108);
            this.lstHeroes.TabIndex = 5;
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(12, 9);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(80, 20);
            this.lblNumbers.TabIndex = 6;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroes.Location = new System.Drawing.Point(215, 9);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(67, 20);
            this.lblHeroes.TabIndex = 7;
            this.lblHeroes.Text = "Heroes";
            // 
            // lblSelectNumbers
            // 
            this.lblSelectNumbers.AutoSize = true;
            this.lblSelectNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectNumbers.Location = new System.Drawing.Point(14, 176);
            this.lblSelectNumbers.Name = "lblSelectNumbers";
            this.lblSelectNumbers.Size = new System.Drawing.Size(193, 16);
            this.lblSelectNumbers.TabIndex = 8;
            this.lblSelectNumbers.Text = "Select a number to remove";
            // 
            // lblEnterHeroNameAdd
            // 
            this.lblEnterHeroNameAdd.AutoSize = true;
            this.lblEnterHeroNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterHeroNameAdd.Location = new System.Drawing.Point(216, 176);
            this.lblEnterHeroNameAdd.Name = "lblEnterHeroNameAdd";
            this.lblEnterHeroNameAdd.Size = new System.Drawing.Size(186, 16);
            this.lblEnterHeroNameAdd.TabIndex = 9;
            this.lblEnterHeroNameAdd.Text = "Enter a hero name to add:";
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumber.Location = new System.Drawing.Point(17, 195);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveNumber.TabIndex = 10;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(98, 195);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAllNumbers.TabIndex = 11;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            // 
            // btnAddHero
            // 
            this.btnAddHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHero.Location = new System.Drawing.Point(325, 195);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(50, 23);
            this.btnAddHero.TabIndex = 12;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHero.Location = new System.Drawing.Point(298, 235);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(77, 23);
            this.btnRemoveHero.TabIndex = 13;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(13, 278);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status";
            // 
            // lblEnterHeroRemove
            // 
            this.lblEnterHeroRemove.AutoSize = true;
            this.lblEnterHeroRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterHeroRemove.Location = new System.Drawing.Point(216, 218);
            this.lblEnterHeroRemove.Name = "lblEnterHeroRemove";
            this.lblEnterHeroRemove.Size = new System.Drawing.Size(211, 16);
            this.lblEnterHeroRemove.TabIndex = 15;
            this.lblEnterHeroRemove.Text = "Enter a hero name to remove:";
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(219, 195);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(100, 20);
            this.txtAddHero.TabIndex = 16;
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(219, 237);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(73, 20);
            this.txtRemoveHero.TabIndex = 17;
            // 
            // ListBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.lblEnterHeroRemove);
            this.Controls.Add(this.lblStatus);
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
            this.Name = "ListBoxes";
            this.Text = "Form1";
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
    }
}

