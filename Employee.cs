using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace SimpleBillingSystem
{
    public class Employee
    {
        public string EmpName;
        
        public static  Dictionary<string, string> EmpDetails = new Dictionary<string, string>();

        public string Login() 
        {
            return DateTime.Now.ToString("G");
        }

        public static void fetchEmpDetails(string path)
        {
            string[] EmpDetailArr = File.ReadAllLines(path);
            EmpDetails.Clear();
            foreach (string emp in EmpDetailArr)
            {
                EmpDetails.Add(emp.Split('|')[0],emp.Split('|')[1]);
            }
        }
    }
}
