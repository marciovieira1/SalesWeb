using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(60,MinimumLength =3,ErrorMessage ="O {0} deve ter entre {2} e {1} caracteres")]
        [Display(Name="Nome")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage ="Email informado é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name="Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MMM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name ="Salário Base")]
        [DisplayFormat(DataFormatString ="{0:c}")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve ser maior ou igual a {1} e menor ou igual a {2}")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        [Display(Name ="Departamento")]
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
