using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ITMO.ASP.NET.GradeBook.Sim.Models
{
    //Контекст
    public class GradeBookContext : DbContext
    {
        public DbSet<GradeBookModel> gradeBookModels { get; set; }        
    }

    // Модель базы данных
    public class GradeBookModel
    {
        [Key]
        public virtual int GradeBookID { get; set; }
        [DisplayName("Имя студента")]
        [Required(ErrorMessage = "ФИО студента обязательно для заполнения.")]
        public virtual string StudentName { get; set; }
        [DisplayName("Номер группы")]
        [Required(ErrorMessage = "Номер группы обязательно для заполнения.")]
        public virtual string Group { get; set; }
        [Range(1, 5, ErrorMessage = "Допустимы значения от {1} до {2}.")]
        [DisplayName("Технологии программирования")]
        public virtual int Grade1 { get; set; }
        [Range(1, 5, ErrorMessage = "Допустимы значения от {1} до {2}.")]        
        [DisplayName("Введение в БД")]
        public virtual int Grade2 { get; set; }
        [Range(1, 5, ErrorMessage = "Допустимы значения от {1} до {2}.")]        
        [DisplayName("C#")]
        public virtual int Grade3 { get; set; }
        [Range(1, 5, ErrorMessage = "Допустимы значения от {1} до {2}.")]        
        [DisplayName("TSQL")]
        public virtual int Grade4 { get; set; }
        [Range(1, 5, ErrorMessage = "Допустимы значения от {1} до {2}.")]        
        [DisplayName("Разработка Win-приложений")]
        public virtual int Grade5 { get; set; }
        [Range(1, 5, ErrorMessage = "Допустимы значения от {1} до {2}.")]        
        [DisplayName("HTML and CSS")]
        public virtual int Grade6 { get; set; }
        [Range(1, 5, ErrorMessage = "Допустимы значения от {1} до {2}.")]        
        [DisplayName("ADO.NET")]
        public virtual int Grade7 { get; set; }
        [Range(1, 5, ErrorMessage = "Допустимы значения от {1} до {2}.")]        
        [DisplayName("ASP.NET")]
        public virtual int Grade8 { get; set; }
    }

}