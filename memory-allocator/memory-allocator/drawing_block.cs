using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace memory_allocator
{
    class drawing_block
    {
        private string id;
        private decimal address;
        private decimal size;

        public drawing_block(string i ,decimal a , decimal s )
        {
            id = i;
            address = a;
            size = s;
        }

        public string get_id()
        {
            return id;
        }

        public decimal get_address()
        {
            return address;
        }

        public decimal get_size()
        {
            return size;
        }
        public void set_id(string num)
        {
            id = num;
        }

        public void set_address(decimal a)
        {
            address = a;
        }

        public void set_size(decimal num)
        {
            size = num;
        }
    }
}
