using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Equipment:IEntity
    {
        public Equipment()
        {
        //    Clinic = new Clinic();
        }
     
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfSupply { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double UsageRate{ get; set; }
        public int ClinicId { get; set; }
       // public virtual Clinic Clinic { get; set; }
    }
}

