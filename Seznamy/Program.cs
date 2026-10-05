namespace Seznamy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Jak tě oslovují?");

            //string? jmeno;
            //jmeno = Console.ReadLine();

            //Console.WriteLine("Ahoj " + jmeno);
            
            var list = new List<string>() { "Pepa", "Karel", "Kryštof" };

            Console.WriteLine (string.Join(",", list));

            list.Add("Ivan");

            Console.WriteLine(string.Join(",", list));

            list.Remove("Pepa");

            Console.WriteLine(string.Join(",", list));

            Console.ReadKey();

            var s1 = new Student(); s1.Jmeno = "Adolf"; s1.Body = 50;

            var s2 = new Student() { Jmeno="Ferko", Body = 10 };

            var s3 = new Student("Karel", 75);

            var liststud = new List<Student>() { s1, s2, s3 };

            foreach (var student in liststud)
            {
                //Console.WriteLine(student.Jmeno+" - "+student.Body);
                Console.WriteLine(student.Popis);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Počet" + liststud.Count);

            //Console.WriteLine("Počet bodů" + liststud.Sum(VyberBody))


            Console.WriteLine("Počet bodů" + liststud.Sum(x => x.Body));

            Console.WriteLine("Počet bodů pro studenty s více než 14 body" + liststud.Where(x => x.Body > 14).Sum(x => x.Body));

            var vybrani = liststud.Where(x => x.Body > 14).ToList();
            vybrani .ForEach(x => Console.WriteLine(x.Popis));
        }
    }

  
    public class Student
        {   
            public Student() { }
            public Student(string jmeno, int body) 
            {
                Jmeno = jmeno;
                Body = body;
            }
            public string? Jmeno { get; set; }
            public int Body { get; set; }

            public string? Popis => Jmeno + " - " + Body;
            
        }
       

}
