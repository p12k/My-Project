namespace MyProject.Common
{
    public class Constants
    {
      public class StoreProcedure
        {
        public const string sp_Employee = "sp_InsertEmployeePractice";
        }

        public class Connection
        {
            public const string ConnectionString = "Data Source = DESKTOP-I9F84R8;Initial Catalog = Employee;Integrated Security = True";
        }
        public class table {
        public const string MyAllEmployee = "EmployeePractice";
           }
        public class Common
        {
            public const string All = "Select * from ";
            public const string Id = "@Id";
            public const string Name = "@Name";
            public const string Age = "@Age";
            public const string Description = "@Description";
            public const string Pincode = "@Pincode";
        }


    }
}
