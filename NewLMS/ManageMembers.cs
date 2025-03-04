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
    public partial class ManageMembers : Form
    {
        private MemberList members;
        public ManageMembers(MemberList list)
        {
            InitializeComponent();
            this.members = list;
            loadDatagridviewM();
            loadcombobox();
        }

        public void loadDatagridviewM()
        {
            if (dataGridView1 == null)
            {
                return;
            }

            dataGridView1.Rows.Clear();

            if (members == null || members.Head == null)
            {
                return;
            }

            mNode? current = members.Head;
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
        public void loadcombobox()
        {
            cmbmemlist.Items.Clear();
            mNode? current = members.Head;
            while (current != null)
            {
                Member mem = current.Data;
                cmbmemlist.Items.Add(mem.Id);
                current = current.Next;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txtcity.Text) || string.IsNullOrEmpty(txtage.Text))
            {
                MessageBox.Show("Please Enter Every Values");
                return;
            }

            Member newmember = new Member(txtname.Text, txtid.Text, txtcity.Text, txtage.Text, comboBox1.Text);
            members.AddLast(newmember);
            MessageBox.Show("Member Added Succesfully");

            txtage.Clear();
            txtcity.Clear();
            txtid.Clear();
            txtname.Clear();
            comboBox1.SelectedIndex = -1;
            loadDatagridviewM();
            loadcombobox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(cmbmemlist.Text, out number))
            {
                members.remove(number);
            }
            else
            {
                MessageBox.Show("Enter Valid Index");
            }
            cmbmemlist.SelectedIndex = -1;
            loadDatagridviewM();
            loadcombobox();


        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            members.sorta();
            loadDatagridviewM();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            members.sortd();
            loadDatagridviewM();
        }
    }
}
