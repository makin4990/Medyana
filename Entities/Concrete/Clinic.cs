using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Entities.Concrete
{
    public class Clinic:IEntity
    {
       

        public Clinic()
        {
            Equipments = new List<Equipment>();
           
        }
        
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [Display(Name = "Equipments")]
        public virtual List<Equipment> Equipments { get; set; }
       
    }
}
