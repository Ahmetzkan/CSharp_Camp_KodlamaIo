using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity = Varlık
        //CRUD = Create-Read-Update-Delete
        //Get= Oku --- Set = Ata --- Yani oku ve ata anlamına geliyor.
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int CategoryId { get; set; } 
        public int UnitsInStock { get; set; }

    }
}
