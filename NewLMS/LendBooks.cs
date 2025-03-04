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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewLMS
{
    public partial class LendBooks : Form
    {
        private BookList bookList;
        private MemberList memberList;
        private LendList lendList;
        public LendBooks(LendList lList, BookList bList, MemberList mList)
        {
            InitializeComponent();
            this.lendList = lList;
            this.memberList = mList;
            this.bookList = bList;
            loadcomboboxes();
            loadDatagridviewl();
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
                    dataGridViewl.Rows.Add(lend.Id,lend.memberId,lend.bookId,lend.Date,lend.DueDate);
                }
                current = current.Next;
            }
        }

        public void loadcomboboxes()
        {
            comboBoxb.Items.Clear();
            comboBoxm.Items.Clear();
            mNode? current = memberList.Head;
            while (current != null)
            {
                Member mem = current.Data;
                comboBoxm.Items.Add(mem.Id);
                current = current.Next;
            }
            Node? currentb = bookList.Head;
            while (currentb != null)
            {
                Book book = currentb.Data;
                comboBoxb.Items.Add(book.Id);
                currentb = currentb.Next;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxb.Text) || string.IsNullOrEmpty(comboBoxm.Text))
            {
                MessageBox.Show("Please Enter Both Values");
                return;
            }

            DateTime date = dateTimePicker1.Value;
            DateTime duedate = date.AddDays(14);




            Lend newLend = new Lend(comboBoxb.Text, comboBoxm.Text, date.ToString("yyyy-MM-dd"),duedate.ToString("yyyy-MM-dd"));
            lendList.AddLast(newLend);
            loadDatagridviewl();
            comboBoxb.SelectedIndex = -1;
            comboBoxm.SelectedIndex = -1;
            
            
        }
    }
}
