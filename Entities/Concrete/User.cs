using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User : BaseEntity, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        //Parola Alanları

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


    }
}
