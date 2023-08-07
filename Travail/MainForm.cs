namespace Travail
{
    public partial class MainForm : Form
    {
        private List<Livre> borrowedBooksList = new List<Livre>();

        // Make the library variable static
        public static Biblioteque library = new Biblioteque();

        // Properties to get references to BookForm and AuthForm
        public BookForm BookFormInstance { get; private set; }
        public AuthForm AuthFormInstance { get; private set; }

        public MainForm()
        {
            InitializeComponent();

            // Initialize the BookForm and AuthForm instances
            BookFormInstance = new BookForm();
            AuthFormInstance = new AuthForm();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            // Show the BookForm with the MainForm as the owner
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog(this);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            // Create a new instance of BorrowForm and show it
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Create a new instance of ReturnForm and show it
            ReturnForm returnForm = new ReturnForm();
            returnForm.Show();
        }

        private void btnManageAuthorizedPersons_Click(object sender, EventArgs e)
        {
            // Show the AuthForm with the MainForm as the owner
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}