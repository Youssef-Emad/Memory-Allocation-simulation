using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace memory_allocator
{
    class hole
    {
        private string id;
        private decimal size;
        private decimal address;

        public hole(string i, decimal s, decimal a)
        {
            id = i;
            size = s;
            address = a;
        }

        public hole(string i, decimal s)
        {
            id = i;
            size = s;
        }

        public string get_id()
        {
            return id;
        }

        public decimal get_size()
        {
            return size;
        }

        public decimal get_address()
        {
            return address;
        }

        public void set_id(string num)
        {
            id = num;
        }

        public void set_size(decimal num)
        {
            size = num;
        }

        public void set_address(decimal a)
        {
            address = a;
        }

        public void update(decimal a, decimal s)
        {
            address = a;
            size = s;
        }

    }
}
