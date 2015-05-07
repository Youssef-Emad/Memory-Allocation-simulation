using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace memory_allocator
{
    class process
    {
        private string id;
        private decimal size;

        public process(string i, decimal s)
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
        public void set_id(string num)
        {
            id = num;
        }

        public void set_size(decimal num)
        {
            size = num;
        }
    }
}
