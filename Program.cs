using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace quanly_SinhVien
{
    public class Students
    {

        public Students()
        {
        }

        public Students(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            List<Students> list_ST = new List<Students>();
            list_ST.Add(new Students { Id = 3762, Name = "Vu" ,Age = 20});
            list_ST.Add(new Students { Id = 3766, Name = "Bao", Age = 15 });
            list_ST.Add(new Students { Id = 1244, Name = "Minh", Age = 20 });
            list_ST.Add(new Students { Id = 2423, Name = "Kien", Age = 16 });
            list_ST.Add(new Students { Id = 2493, Name = "NGHI", Age = 27 });

          
            Console.WriteLine("danh sach hoc sinh");
            foreach(var  student in list_ST)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name},  Age: {student.Age}");

            }
           
            Console.WriteLine("Danh sach sinh vien tu 15 den 18");
            var stAge15to18 = list_ST.Where(st => st.Age >= 15 && st.Age < 18);
            foreach (var student in stAge15to18)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name},  Age: {student.Age}");

            }
            Console.WriteLine("danh sach sinh vien co chu cai bat dau bang chu A");
            var svStarA = list_ST.Where(st => st.Name.StartsWith("A"));
            foreach (var student in svStarA)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name},  Age: {student.Age}");

            }
            Console.WriteLine("Tinh tong tuoi tat ca ca sinh vien");
            int sumAge = list_ST.Sum(st => st.Age);
            Console.WriteLine($"sum = {sumAge}");
            Console.ReadLine();

            }
          
   
       
    }
}
