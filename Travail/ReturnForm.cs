using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail
{
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
            dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            // Create a new instance of MainForm and show it
            MainForm mainForm = new MainForm();
            mainForm.Show();

            // Close the current form (the current form will be closed when the user goes back to the MainForm)
            this.Close();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBorrowedBooks.SelectedRows[0];
                Livre selectedBook = ((KeyValuePair<Livre, Personne>)selectedRow.DataBoundItem).Key;

                // Return the selected borrowed book using MainForm.library
                if (MainForm.library.ReturnBook(selectedBook))
                {
                    // Refresh the DataGridView after returning the book
                    dgvBorrowedBooks.DataSource = new BindingSource(MainForm.library.GetBorrowedBooks(), null);
                    // Update Available Books DataGridView in MainForm (if MainForm is kept open)
                }
                else
                {
                    MessageBox.Show("Unable to return the selected book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a borrowed book to return.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
