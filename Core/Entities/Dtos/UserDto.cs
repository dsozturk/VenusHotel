using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Dtos
{
    //Kullanıcının temel bilgileri yer alır.
    public class UserDto : BaseDto, IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public byte[] ProfilePicture { get; set; }

    }

    //Kullanıcının giriş için kullanacağı alanlardır.
    public class LoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }

    //Kullanıcının kayıt olurken kullanacağı alanlardır.
    public class RegisterDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }


}
