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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewLMS
{

    public partial class ReturnBooks : Form
    {
        private BookList bookList;
        private MemberList memberList;
        private LendList lendList;
        public ReturnBooks(LendList lList, BookList bList, MemberList mList)
        {
            InitializeComponent();
            this.lendList = lList;
            this.memberList = mList;
            this.bookList = bList;
            loadcombobox();
            loadDatagridviewr();
        }
        public void loadDatagridviewr()
        {
            if (dataGridViewr == null)
            {
                return;
            }

            dataGridViewr.Rows.Clear();

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
                    dataGridViewr.Rows.Add(lend.Id, lend.memberId, lend.bookId, lend.Date, lend.DueDate);
                }
                current = current.Next;
            }
        }
        public void loadcombobox()
        {
            comboBox1.Items.Clear();
            lNode? current = lendList.Head;
            while (current != null)
            {
                Lend lend = current.Data;
                comboBox1.Items.Add(lend.Id);
                current = current.Next;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(comboBox1.Text, out number))
            {
                lendList.remove(number);
            }
            else
            {
                MessageBox.Show("Enter Valid Index");
            }
            comboBox1.SelectedIndex = -1;
            loadDatagridviewr();
            loadcombobox();
        }
    }
}
