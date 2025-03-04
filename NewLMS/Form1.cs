using NewLMS.Data_Structures;

namespace NewLMS
{
    public partial class main : Form
    {
        private BookList bookList;
        private MemberList memberList;
        private LendList lendList;
        public main()
        {
            InitializeComponent();



            loadform(new Home(bookList, memberList, lendList));
            bookList = new BookList();
            memberList = new MemberList();
            lendList = new LendList();
            //loaddatab();
            //loaddatam();

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        /*public void loaddatab()
        {
            string filePath = "D:\\Local Repos\\NewLMS\\NewLMS\\Data\\books_dataset.txt";

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 2)
                {

                    string title = parts[0];
                    string author = parts[1];

                    Book book = new Book(title, author);

                    bookList.AddLast(book);

                }
            }

        }*/
        /*public void loaddatam()
        {
            string filePath = "D:\\Local Repos\\NewLMS\\NewLMS\\Data\\custom_dataset.txt";

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 5)
                {

                    string name = parts[0];
                    string city = parts[1];
                    string age = parts[2];
                    string gender = parts[3];
                    string natid = parts[4];

                    Member mem = new Member(name, natid, city, age, gender);

                    memberList.AddLast(mem);

                }
            }

        }*/

        private void ManageBooks_Click(object sender, EventArgs e)
        {
            loadform(new Managebooks(bookList));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new ManageMembers(memberList));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new LendBooks(lendList, bookList, memberList));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new ReturnBooks(lendList, bookList, memberList));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Managebooks(bookList));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new Home(bookList, memberList, lendList));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
