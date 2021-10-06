using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.ASP.NET.GradeBook.Sim.Models
{
    public class GradeBookDbInitializer : DropCreateDatabaseIfModelChanges<GradeBookContext>
    {
        protected override void Seed(GradeBookContext context)
        {
            context.gradeBookModels.Add(new GradeBookModel
            {
                StudentName = "Алексеев Алексей Алексеевич",
                Group = "124/3",
                Grade1 = 4,
                Grade2 = 4,
                Grade3 = 5,
                Grade4 = 3,
                Grade5 = 4,
                Grade6 = 3,
                Grade7 = 3,
                Grade8 = 4
            });
            context.gradeBookModels.Add(new GradeBookModel
            {
                StudentName = "Василенко Василий Васильевич",
                Group = "124/3",
                Grade1 = 3,
                Grade2 = 5,
                Grade3 = 2,
                Grade4 = 4,
                Grade5 = 4,
                Grade6 = 4,
                Grade7 = 5,
                Grade8 = 2
            });
            context.gradeBookModels.Add(new GradeBookModel
            {
                StudentName = "Владимиров Владимир Владимирович",
                Group = "124/3",
                Grade1 = 3,
                Grade2 = 2,
                Grade3 = 3,
                Grade4 = 4,
                Grade5 = 5,
                Grade6 = 4,
                Grade7 = 3,
                Grade8 = 3
            });
            context.gradeBookModels.Add(new GradeBookModel
            {
                StudentName = "Иванов Иван Иванович",
                Group = "124/3",
                Grade1 = 4,
                Grade2 = 3,
                Grade3 = 5,
                Grade4 = 3,
                Grade5 = 4,
                Grade6 = 2,
                Grade7 = 3,
                Grade8 = 5
            });
            context.gradeBookModels.Add(new GradeBookModel
            {
                StudentName = "Кузьмин Кузьма Кузьмич",
                Group = "124/3",
                Grade1 = 2,
                Grade2 = 4,
                Grade3 = 3,
                Grade4 = 3,
                Grade5 = 4,
                Grade6 = 4,
                Grade7 = 5,
                Grade8 = 3
            });
            context.gradeBookModels.Add(new GradeBookModel
            {
                StudentName = "Николаев Николай Николаевич",
                Group = "124/3",
                Grade1 = 2,
                Grade2 = 3,
                Grade3 = 4,
                Grade4 = 4,
                Grade5 = 4,
                Grade6 = 3,
                Grade7 = 4,
                Grade8 = 5
            });
            context.gradeBookModels.Add(new GradeBookModel
            {
                StudentName = "Павлов Павел Павлович",
                Group = "124/3",
                Grade1 = 3,
                Grade2 = 3,
                Grade3 = 3,
                Grade4 = 3,
                Grade5 = 4,
                Grade6 = 5,
                Grade7 = 5,
                Grade8 = 3
            });
            context.gradeBookModels.Add(new GradeBookModel
            {
                StudentName = "Сергеев Сергей Сергеевич",
                Group = "124/3",
                Grade1 = 2,
                Grade2 = 3,
                Grade3 = 3,
                Grade4 = 4,
                Grade5 = 3,
                Grade6 = 4,
                Grade7 = 5,
                Grade8 = 4
            });
           
            base.Seed(context);
        }
    }
}