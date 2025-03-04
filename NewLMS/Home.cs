using NewLMS.Data_Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLMS
{
    public partial class Home : Form
    {
        private BookList bookList;
        private MemberList memberList;
        private LendList lendList;
        public Home(BookList list, MemberList memberList, LendList lendList)
        {
            InitializeComponent();
            this.bookList = list;
            loadDatagridview();

            this.memberList = memberList;
            loadDatagridviewM();

            this.lendList = lendList;
            loadDatagridviewl();

            
        }
        public void loadbooks()
        {

        }

        public void loadDatagridviewM()
        {
            if (dataGridView1 == null)
            {
                return;
            }

            dataGridView1.Rows.Clear();

            if (memberList == null || memberList.Head == null)
            {
                return;
            }

            mNode? current = memberList.Head;
            while (current != null)
            {

                Member mem = current.Data;
                if (mem != null)
                {
                    dataGridView1.Rows.Add(mem.Id, mem.Name, mem.NatID, mem.City, mem.Age, mem.Sex);
                }
                current = current.Next;
            }
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
        public void loadDatagridviewl()
        {
            if (dataGridViewl == null)
            {
                return;
            }

            dataGridViewl.Rows.Clear();

            if (lendList == null || lendList.Head == null)
            {
                return;
            }

            lNode? current = lendList.Head;
            while (current != null)
            {

                Lend lend = current.Data;
                if (lend != null)
                {
                    dataGridViewl.Rows.Add(lend.Id, lend.memberId, lend.bookId, lend.Date, lend.DueDate);
                }
                current = current.Next;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadDatagridview();
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
