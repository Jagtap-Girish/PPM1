using System;
using System.Collections.Generic;

namespace ProlificsProjectManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Number for operation");
            Console.WriteLine("1) Add Project");
            Console.WriteLine("2) View Project");
            Console.WriteLine("3) Add Employee");
            Console.WriteLine("4) View Employee");
            Console.WriteLine("5) Add Role");
            Console.WriteLine("6) View Role");
            Console.WriteLine("7) Quit");

           
          
          

            List<string[]> projects = new List<string[]>();
            List<string[]> employees = new List<string[]>();
            List<string[]> roles = new List<string[]>();
            bool j = true;
            while (j)
            {
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                         
                        string[] Project = new string[4];
                        string name;
                        string Start_Date;
                        string End_Date;
                        string Budget;
                        Console.WriteLine("Enter Project Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Project Start Date");
                        Start_Date = Console.ReadLine();
                        Console.WriteLine("Enter Project End Date");
                        End_Date = Console.ReadLine();
                        Console.WriteLine("Enter Project budget");
                        Budget = Console.ReadLine();
                        Console.WriteLine("If you want to add another project press 1");

                        Project[0] = "Name :" + name;
                        Project[1] = "Start_Date :" + Start_Date;
                        Project[2] = "End_Date0 :" + End_Date;
                        Project[3] = "Budget :" + Budget;


                        projects.Add(Project);
                       
     
                        break;
                   
                    case 2:
                        int c=1;
                        foreach (var item in projects)
                        {
                            Console.WriteLine("Project no " + c);
                            foreach (var elements in item) {
                                Console.WriteLine(elements);
                            }
                            c++;
                        }
                        break;
                    case 3:
                        string[] Employee = new string[5];
                        string Id;
                        string First_name;
                        string Last_name;
                        string Contact;
                        string RoleId;
                        Console.WriteLine("Enter Employee Id");
                        Id = Console.ReadLine();
                        Console.WriteLine("Enter Employee First Name");
                        First_name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Last Name");
                        Last_name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Contact");
                        Contact = Console.ReadLine();
                        Console.WriteLine("Enter Employee RoleId");
                        RoleId = Console.ReadLine();
                        Console.WriteLine("If you want to add another employee press 3");
                        Employee[0] = "Id :" + Id;
                        Employee[1] = "First name :" + First_name;
                        Employee[2] = "Last_name :" + Last_name;
                        Employee[3] = "Contact :" + Contact;
                        Employee[4] = "RoleId :" + RoleId;
                        employees.Add(Employee);
                        break;
                    case 4:
                        int i = 1;
                        foreach (var item in employees)
                        {
                            
                            Console.WriteLine("Employee no "+i);
                            foreach (var emp in item)
                            {
                                Console.WriteLine(emp);
                                
                            }
                            i++;
                         }
                        break;
                    case 5:
                        string[] Role = new string[2];
                        string Roleid;
                        string RoleName;
                        Console.WriteLine("Enter Role Id");
                        Roleid = Console.ReadLine();
                        Console.WriteLine("Enter Project RoleName");
                        RoleName = Console.ReadLine();
                        Console.WriteLine("If you want to add another role press 5");
                        Role[0] = "Roleid :" + Roleid;
                        Role[1] = "Role Name :" + RoleName;
                        roles.Add(Role);
                        break;
                    case 6:
                        int count = 1;
                        foreach (var item in roles)
                        {
                            Console.WriteLine("Role no "+count);
                            foreach (var element in item)
                            {
                                Console.WriteLine(element);
                            }
                            count++;
                        }
                        break;
                    case 7:

                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
