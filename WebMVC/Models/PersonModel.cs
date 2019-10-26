using System;
using System.ComponentModel.DataAnnotations;
using GJJA.RegistraVoce.Domain;
using GJJA.RegistraVoce.Domain.Enums;

namespace WebMVC.Models
{
    public class PersonModel
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public Gender Gender { get; set; }
       public string DocumentNumber { get; set; }
       public string Identification { get; set; }
       public MeritalStatus MeritalStatus { get; set; }
       [DataType(DataType.Date)]
       public DateTime BirthDate { get; set; }
       public string Address { get; set; }
       public string Phone { get; set; }
       public PersonModel()
       {
           
       }

    public PersonModel(Person person)
{
            Id = person.Id;
            Name = person.Name;
            Gender = person.Gender;
            DocumentNumber = person.DocumentNumber;
            Identification = person.Identification;
            BirthDate = person.BirthDate;
            MeritalStatus = person.MeritalStatus;
            Address = person.Address;
            Phone = person.Phone; 
}
}
}
