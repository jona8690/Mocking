using System;

namespace Mocking
{
    public enum Rights { Full, None };
    public class User
    {
        public User()
        {
        }

        public int NumMessagesCreated { get; internal set; }
        public string Password { get; set; }
        public Rights Rights { get; internal set; }

        public string UserName { get; set; }

        internal string ViewAllEmployees()
        {
            return "Here is the list";
        }

        internal void EditEmployeeName(Employee e, string v)
        {
            e.Name = v;
               
        }

        internal void EditEmployeeWage(Employee e, int v)
        {
            e.Wage = v;
        }

        internal void EditEmployeeType(Employee e, string v)
        {
            e.Type = v;
        }
    }

}