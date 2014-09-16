﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    class Waiter
    {
        public int WaiterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ReleaseDate { get; set; }

        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }

        #region Navigation Properties

        public virtual ICollection<Bill> Bills { get; set; }

        #endregion
    }//end Class

}//end namespace