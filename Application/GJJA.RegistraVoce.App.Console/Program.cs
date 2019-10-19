using System.Collections.Generic;
using UI = System.Console;
using System;
using GJJA.RegistraVoce.Domain;
using GJJA.RegistraVoce.Domain.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GJJA.RegistraVoce.DataAccess.Entity.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using GJJA.RegistraVoce.App.Console.Factories;
using GJJA.Repository.Common.Interfaces;
using GJJA.RegistraVoce.Repository.Entity;

namespace GJJA.RegistraVoce.App.Console
{
    class Program
    {
        private static string _connectionstring = "";
        private static ServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            SetUp();
            int opcao = -1;
            UI.WriteLine($"*** Bem Vindo *** {Environment.NewLine}");
            while (opcao != 0)
            {
                UI.WriteLine($" O que você deseja fazer? {Environment.NewLine}");
                UI.WriteLine(" 1. Listar pessoas");
                UI.WriteLine(" 2. Inserir pessoas");
                UI.WriteLine(" 3. Atualizar pessoas");
                UI.WriteLine(" 4. Deletar pessoas");
                UI.WriteLine(" 5. Contar pessoas");
                UI.WriteLine(" 0. Sair");
                opcao = Convert.ToInt32(UI.ReadLine());
                switch (opcao)
                {
                    case 0:
                        UI.WriteLine(" Tchau! ;) ");
                        break;
                    case 1:
                        ShowPeople();
                        break;
                    case 2:
                        InsertPerson();
                        break;
                    case 3:
                        UpdatePerson();
                        break;
                    case 4:
                        DeletePerson();
                        break;
                    case 5:
                        CountPeople();
                        break;
                    default:
                        UI.WriteLine(" Opção Inválida!");
                        break;
                }
            }
        }

        private static void CountPeople()
        {
            try
            {
                ICrudRepository<Person, int> personRepository = _serviceProvider.GetService<ICrudRepository<Person, int>>();
                UI.WriteLine($"Existe(m) {personRepository.Select().Count()} pessoa(s) cadastrada(s). ");
            }
            catch (Exception ex)
            {
                UI.WriteLine($"Houve um erro ao contar pessoas: {ex.Message}");
            }
        }

        private static void DeletePerson()
        {
            try
            {
                ShowPeople();
                UI.Write("ID da pessoa a ser atualizada: ");
                int personId = Convert.ToInt32(UI.ReadLine());
                ICrudRepository<Person, int> personRepository = _serviceProvider.GetService<ICrudRepository<Person, int>>();
                personRepository.DeleteById(personId);

            }
            catch (Exception ex)
            {
                UI.WriteLine($"Houve um erro ao deletar pessoa: {ex.Message}");
            }
        }

        private static void UpdatePerson()
        {
            try
            {
                ShowPeople();
                UI.Write("ID da pessoa a ser atualizada: ");
                int personId = Convert.ToInt32(UI.ReadLine());
                ICrudRepository<Person, int> personRepository = _serviceProvider.GetService<ICrudRepository<Person, int>>();
                Person p = personRepository.SelectById(personId);
                if (p == null)
                {
                    throw new ArgumentException("Id de pessoa inexistente. ");
                }
                GetPersonFromUI(p);
                personRepository.Insert(p);


            }
            catch (Exception ex)
            {
                UI.WriteLine($"Houve um erro ao atualizar pessoa: {ex.Message}");
            }
        }


        private static void InsertPerson()
        {
            try
            {
                UI.WriteLine("** Inserção de pessoa **");
                Person person = new Person();
                GetPersonFromUI(person);
                ICrudRepository<Person, int> PersonRepository = _serviceProvider.GetService<ICrudRepository<Person, int>>();
                PersonRepository.Insert(person);
                UI.WriteLine(" ** Pessoa cadastrada com sucesso! **");
            }
            catch (Exception ex)
            {
                UI.WriteLine($"Houve um erro ao salvar pessoa: {ex.Message}");
            }
        }

        private static void ShowPeople()
        {
            ICrudRepository<Person, int> PersonRepository = _serviceProvider.GetService<ICrudRepository<Person, int>>();
            List<Person> people = PersonRepository.Select();
            if (people.Count == 0)

            {
                UI.WriteLine("Não existe pessoas cadastradas!! ");
            }
            else
                people.ForEach(Person =>
                {
                    UI.WriteLine($"[{Person.Id}] {Person.Name}");
                });
        }
        private static void GetPersonFromUI(Person person)
        {
            if (string.IsNullOrEmpty(person.Name))
            {
                UI.Write(" - Nome: ");
                person.Name = UI.ReadLine();
                UI.Write(" - Gênero (0 = M, 1 = F, 2 = Indefinido): ");
                person.Gender = (Gender)Convert.ToInt32(UI.ReadLine());
                UI.Write(" - CPF: ");
                person.DocumentNumber = UI.ReadLine();
                UI.Write(" - RG: ");
                person.Identification = UI.ReadLine();
                UI.Write(" - Data de Nascimento: ");
                person.BirthDate = Convert.ToDateTime(UI.ReadLine());
                UI.Write(" - Estado Civil (0 = Solteiro, 1 = Casado, 2 = Divorciado, 3 = Viuva.): ");
                person.MeritalStatus = (MeritalStatus)Convert.ToInt32(UI.ReadLine());
                UI.Write(" - Endereço: ");
                person.Address = UI.ReadLine();
                UI.Write(" - Telefone:  ");
                person.Phone = UI.ReadLine();
            }
            else
            {
                UI.Write($" - Nome: ({person.Name}) ");
                person.Name = UI.ReadLine();
                UI.Write($" - Gênero (0 = M, 1 = F, 2 = Indefinido) ({person.Gender}): ");
                person.Gender = (Gender)Convert.ToInt32(UI.ReadLine());
                UI.Write($" - CPF ({person.DocumentNumber}): ");
                person.DocumentNumber = UI.ReadLine();
                UI.Write($" - RG ({person.Identification}): ");
                person.Identification = UI.ReadLine();
                UI.Write($" - Data de Nascimento ({person.BirthDate}): ");
                person.BirthDate = Convert.ToDateTime(UI.ReadLine());
                UI.Write($" - Estado Civil (0 = Solteiro, 1 = Casado, 2 = Divorciado, 3 = Viuva.): ({person.MeritalStatus}): ");
                person.MeritalStatus = (MeritalStatus)Convert.ToInt32(UI.ReadLine());
                UI.Write($" - Endereço ({person.Address}): ");
                person.Address = UI.ReadLine();
                UI.Write($" - Telefone ({person.Phone}): ");
                person.Phone = UI.ReadLine();
            }
        }
        private static void SetUp()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<RegistraVoceDbContext>((provider) =>
            {
                return new RegistraVoceDbContextFactory().CreateDbContext(new string[] { });
            });
            services.AddScoped<ICrudRepository<Person, int>, PersonRepository>();
            _serviceProvider = services.BuildServiceProvider();
        }
    }
}