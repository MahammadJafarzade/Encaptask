using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aaa = new Student(654684,"Mehemmed","Ceferzade","csss");
            Group bbb = new Group("BP201",16);
            aaa.Ixtisas = "cs";
            aaa.Info();
        }
    }
}
