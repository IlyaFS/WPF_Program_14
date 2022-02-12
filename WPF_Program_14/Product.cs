using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Program_14
{
    public enum CategoryTypes
    {
        Food,
        Tech
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public CategoryTypes Category { get; set; }
        public string Image { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
