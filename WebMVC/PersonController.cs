using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using WebMVC.Models;
using WebMVC.Factories;
using GJJA.RegistraVoce.Domain.Enums;
using GJJA.RegistraVoce.Domain;
using System;
using GJJA.RegistraVoce.DataAccess.Entity.Context;
using GJJA.Repository.Common.Interfaces;
using GJJA.RegistraVoce.Repository.Entity;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace WebMVC.Controllers
{
    public class PersonController : Controller
    {
        public PersonController()
        {
            SetUp();
        }
        private static ServiceProvider _serviceProvider;
        public IActionResult Index()
        {
            ICrudRepository<Person, int> PersonRepository = _serviceProvider.GetService<ICrudRepository<Person, int>>();
            List<Person> people = PersonRepository.Select();
            ListPersonModel model = new ListPersonModel(people);
            return View(model);
        }
        public IActionResult Welcome()
        {
            var model = new PersonModel();
            model.Id = 1;
            model.Name = "João";
            model.Gender = Gender.Male;
            model.DocumentNumber = "214.566.735-66";
            model.Identification = "56.372.345-0";
            model.BirthDate = new DateTime(2001,11,1,04,30,15);
            model.MeritalStatus = MeritalStatus.Single;
            model.Address = "Rua 0, numero A";
            model.Phone = "(12)98877-0055";
            return View(model);
        }
        private static void SetUp()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<RegistraVoceDbContext>((provider) =>
            {
                return new WebMVCDbContextFactory().CreateDbContext(new string[] { });
            });
            services.AddScoped<ICrudRepository<Person, int>, PersonRepository>();
            _serviceProvider = services.BuildServiceProvider();
        }
    }
}