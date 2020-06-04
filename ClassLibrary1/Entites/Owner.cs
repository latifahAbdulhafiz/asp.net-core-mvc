using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entites
{
    class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }
    }

}
