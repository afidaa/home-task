using System;

namespace _13_fevral_heftesonu_taski
{
    internal class Program
    {
        static Course course = new Course();

        static void qrupElaveEt()
        {
            Console.WriteLine("Qrupun nomresini daxil et: ");
            string no = Console.ReadLine();
            Console.WriteLine("Qrupun ortalamasini daxil et: ");
            double avgPoint = Convert.ToDouble(Console.ReadLine());

            Group group = new Group(no, avgPoint);
            course.AddGroup(group);
            Console.WriteLine("Qrup elave edildi!");
        }

        static void butunQruplaraBax()
        {
            for (int i = 0; i < course.groups.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", course.groups[i].No, course.groups[i].AvgPoint);
            }
        }

        static void intervallaQrupAxtar()
        {
            Console.Write("Minimum pointi daxil et: ");
            double minPoint = Convert.ToDouble(Console.ReadLine());
            Console.Write("Maximum pointi daxil et: ");
            double maxPoint = Convert.ToDouble(Console.ReadLine());

            Group[] interval_groups = course.GetGroupsByPointRange(minPoint, maxPoint);
            Console.WriteLine("Qrup nomresi\tAvg Point");
            for (int i = 0; i < interval_groups.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", interval_groups[i].No, interval_groups[i].AvgPoint);
            }
        }

        static void nomreyleQrupAxtar()
        {
            Console.WriteLine("Qrupun nomresini daxil et: ");
            string no = Console.ReadLine();
            Group result = course.GetGroupByNo(no);
            if (result != null)
                Console.WriteLine("Netice: {0}\t{1}", result.No, result.AvgPoint);
            else
                Console.WriteLine("Netice tapilmadi");
        }

        static void butunQruplardanAxtar()
        {
            Console.WriteLine("Qrupun nomresini daxil et: ");
            string no = Console.ReadLine();
            Group[] results = course.Search(no);
            Console.WriteLine("Qrup nomresi\tAvg Point");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", results[i].No, results[i].AvgPoint);
            }
        }

        static void Main(string[] args)
        {
            string option;

            do
            {
                Console.WriteLine("\n1. Qrup elave et");
                Console.WriteLine("2. Butun qruplara bax");
                Console.WriteLine("3. Verilmish point araligindaki qruplara bax");
                Console.WriteLine("4. Verilmis nomreli qrupa bax");
                Console.WriteLine("5. Verilmis qruplar uzre axtarish et");
                Console.WriteLine("0. Menudan cix");

                Console.WriteLine("\nSecim edin:");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        qrupElaveEt();
                        break;

                    case "2":
                        butunQruplaraBax();
                        break;

                    case "3":
                        intervallaQrupAxtar();
                        break;

                    case "4":
                        nomreyleQrupAxtar();
                        break;

                    case "5":
                        butunQruplardanAxtar();
                        break;

                    case "0":
                        Console.WriteLine("Proses bitdi!");
                        break;

                    default:
                        Console.WriteLine("Secim duzgun deyil!");
                        break;
                }

            }
            while (option != "0");
        }
    }
}

