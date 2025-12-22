using AutoMapper.Configuration.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Infrasturucture.DTOs.User
{
    public class CreateUserDTO
    {
        public string FullName {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
