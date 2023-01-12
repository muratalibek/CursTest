using System;

namespace CursTest.Models
{
    /// <summary>
    /// КРП - Классификатор размерности предприятий
    /// </summary>
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BIN { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string Adress { get; set; }   
        public string PhoneNumber { get; set; }
        //public ImageSource Image { get; set; }
        public int KRP { get; set; }
        public string CompanyActivity { get; set; }
        public string Description { get; set; }
        public int Staff { get; set; }


    }
}
