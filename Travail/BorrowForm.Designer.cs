namespace Travail
{
    partial class BorrowForm
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
            btnBackToMainForm = new Button();
            label3 = new Label();
            dgvBooks = new DataGridView();
            btnBorrow = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // btnBackToMainForm
            // 
            btnBackToMainForm.Location = new Point(330, 246);
            btnBackToMainForm.Name = "btnBackToMainForm";
            btnBackToMainForm.Size = new Size(132, 50);
            btnBackToMainForm.TabIndex = 5;
            btnBackToMainForm.Text = "Back MainForm";
            btnBackToMainForm.UseVisualStyleBackColor = true;
            btnBackToMainForm.Click += btnBackToMainForm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 43);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Books";
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(71, 61);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowTemplate.Height = 25;
            dgvBooks.Size = new Size(391, 155);
            dgvBooks.TabIndex = 6;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(71, 246);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(132, 50);
            btnBorrow.TabIndex = 7;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click_1;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrow);
            Controls.Add(dgvBooks);
            Controls.Add(btnBackToMainForm);
            Controls.Add(label3);
            Name = "BorrowForm";
            Text = "Borrow Form";
            Load += BorrowForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBackToMainForm;
        private Label label3;
        private DataGridView dgvBooks;
        private Button btnBorrow;
    }
}