using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        private int phone;

        public int Phone
        {
            get { return phone; }
            set
            {
                if (value != 0)
                    phone = value;
            }
        }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}