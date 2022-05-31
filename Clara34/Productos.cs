using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clara34
{
    public class Productos
    {
        private String name;
        private String description;
        private String categoria;
        private int price;

        public Productos (string name, string description, string categoria, int price)
        {
            this.name = name;
            this.description = description;
            this.categoria = categoria;
            this.price = price;
        }

        public String Name { get => name; set => name = value; }
        public String Description { get => description; set => description = value; }
        public String Categoria { get => categoria; set => categoria = value; }
        public int Price { get => price; set => price = value; }


    }

}
 