using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLXM.DTO
{
    class Motorbike
    {

        public Motorbike()
        {
            this.ID = 0;
            this.Name = "";
            this.Manufacturer = null;
            this.Cost = 0;
        }

        public Motorbike(int id, string name, Manufacturer manufacturer, int cost)
        {
            this.ID = id;
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Cost = cost;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int Cost { get; set; }

    }
}
