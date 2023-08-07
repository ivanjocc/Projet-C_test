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
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            // Create a new instance of MainForm and show it
            MainForm mainForm = new MainForm();
            mainForm.Show();

            // Close the current form (the current form will be closed when the user goes back to the MainForm)
            this.Close();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            // Load the list of available books into the DataGridView
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            // Refresh the DataGridView with the latest list of available books
            dgvBooks.DataSource = MainForm.library.GetAvailableBooks();
        }

        private void btnBorrow_Click_1(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];
                Livre selectedBook = (Livre)selectedRow.DataBoundItem;

                // Borrow the selected book (passing null for AuthorizedPerson as we are not selecting one)
                if (MainForm.library.BorrowBook(selectedBook, null)) // Pass null for person
                {
                    // Refresh the DataGridView after borrowing the book
                    RefreshDataGridView();

                    // Close the BorrowForm after borrowing the book
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to borrow the selected book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to borrow.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
