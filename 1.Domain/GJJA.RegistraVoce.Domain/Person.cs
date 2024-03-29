using System;
using GJJA.RegistraVoce.Domain.Enums;

namespace GJJA.RegistraVoce.Domain
{
    public class Person
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public Gender Gender { get; set; }
       public string DocumentNumber { get; set; }
       public string Identification { get; set; }
       public MeritalStatus MeritalStatus { get; set; }
       public DateTime BirthDate { get; set; }
       public string Address { get; set; }
       public string Phone { get; set; }
    }
}