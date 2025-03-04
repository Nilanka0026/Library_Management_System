using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewLMS.Data_Structures;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewLMS
{

    public partial class Managebooks : Form
    {
        private BookList bookList;
        public Managebooks(BookList list)
        {
            InitializeComponent();
            this.bookList = list;
            loadDatagridview();
            loadcombobox();
        }
        public void loadDatagridview()
        {
            if (datagrid == null)
            {
                return;
            }

            datagrid.Rows.Clear();

            if (bookList == null || bookList.Head == null)
            {
                return;
            }

            Node? current = bookList.Head;
            while (current != null)
            {

                Book book = current.Data;
                if (book != null)
                {
                    datagrid.Rows.Add(book.Id, book.Title, book.Author);
                }
                current = current.Next;
            }
        }
        public void loadbooks()
        {

        }
        public void loadcombobox()
        {
            comboBox1.Items.Clear();
            Node? current = bookList.Head;
            while (current != null)
            {
                Book book = current.Data;
                comboBox1.Items.Add(book.Id);
                current = current.Next;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txttitle.Text) || string.IsNullOrEmpty(txtauthor.Text))
            {
                MessageBox.Show("Please Enter Both Values");
                return;
            }

            Book newBook = new Book(txttitle.Text, txtauthor.Text);
            bookList.AddLast(newBook);
            MessageBox.Show("Book Added Succesfully");

            txttitle.Clear();
            txtauthor.Clear();
            loadDatagridview();
            loadcombobox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttitle.Clear();
            txtauthor.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(comboBox1.Text, out number))
            {
                bookList.remove(number);
            }
            else
            {
                MessageBox.Show("Enter Valid Index");
            }
            comboBox1.SelectedIndex = -1;
            loadDatagridview();
            loadcombobox();



        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            bookList.InsertionSortA();
            time.Stop();
            time1.Text = $"Time - {time.Elapsed.TotalNanoseconds} ns";
            time.Reset();
            loadDatagridview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            bookList.InsertionSortD();
            time.Stop();
            time2.Text = $"Time - {time.Elapsed.TotalNanoseconds} ns";
            time.Reset();
            loadDatagridview();
        }
    }
}
