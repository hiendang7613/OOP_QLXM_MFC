using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLXM.DTO
{
    class Customer
    {

        public Customer()
        {
            this.ID = 0;
            this.Fullname = "";
            this.Phone = "";
        }

        public Customer(int id, string fullname, string phone)
        {
            this.ID = id;
            this.Fullname = fullname;
            this.Phone = phone;
        }

        public int ID { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }

    }
}
