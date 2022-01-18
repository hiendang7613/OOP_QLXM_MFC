using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLXM.DTO
{
    class Order
    {

        public Order()
        {
            this.ID = 0;
            Time = default;
            Customer = null;
            Motorbikes = null;
        }

        public Order(int id, DateTime time, List<Motorbike> motorbikes, Customer customer)
        {
            this.ID = id;
            this.Time = time;
            this.Motorbikes = motorbikes;
            this.Customer = customer;
        }

        public int ID { get; set; }
        public List<Motorbike> Motorbikes { get; set; }
        public DateTime Time { get; set; }
        public Customer Customer { get; set; }

    }
}
