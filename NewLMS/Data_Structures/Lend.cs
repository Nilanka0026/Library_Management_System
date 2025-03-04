using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLMS.Data_Structures
{
    public class Lend
    {
        private static int nextid = 3001;
        public int Id;
        public string Date;
        public string DueDate;
        public string bookId;
        public string memberId;


        public Lend(string bookId, string memberId,string date,string duedate)
        {
            this.Date = date;
            this.DueDate = duedate;
            this.Id = nextid;
            this.bookId = bookId;
            this.memberId = memberId;
            nextid = nextid + 1;
        }
    }
}
