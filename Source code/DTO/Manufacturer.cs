using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLXM.DTO
{
    class Manufacturer
    {
        public Manufacturer()
        {
            this.Id = 0;
            this.Name = "";
        }

        public Manufacturer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }


    }
}
