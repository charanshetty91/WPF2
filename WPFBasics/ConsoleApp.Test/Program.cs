using netFrameWork_Lib;
using netFrameWork_Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;

namespace ConsoleApp.Test
{

    class Program
    {
        int a = 10;
        #region Structure example 
        //static void Main(string[] args)
        //{


        //    //Class1 class1 = new Class1();
        //    //StructA1 structA1;
        //    //structA1.a = 10;
        //    //structA1.b = 20;
        //    //class1.M();


        //}
        #endregion

        #region Delegate Example
        // delegate int AddFunc(int a, int b);
        //static void Main(string[] args)
        //    {



        //        //AddFunc addTwoNumber = new AddFunc(AddTwoNumber);
        //        //Console.WriteLine(addTwoNumber(10, 20));
        //        //Console.ReadKey();
        //        //int AddTwoNumber(int a, int b)
        //        //{
        //        //    return a + b;
        //        //}

        //    }
        #endregion

        #region Action

        //public static void Main(string[] args)
        //{

        //    Action<string> Display = PopUpMessage;

        //    Display("Hello Action");

        //    PopUpMessage("hi");


        //    Action<string> Display2 = new Action<string>(PopUpMessage);
        //    Display2("Hi Action Declation2");

        //    Action<string> Disp3 = s => Console.WriteLine(s);
        //    Disp3("Hi Action Declation3");

        //    Action<int> actiondel4 = delegate (int x)
        //    {
        //        Console.WriteLine(x);
        //    };
        //    actiondel4(100928);

        //    Console.ReadKey();
        //}

        //public static void PopUpMessage(string s1)
        //{
        //    Console.WriteLine(s1);
        //}

        #endregion

        #region Func
        ////https://www.tutorialsteacher.com/csharp/csharp-func-delegate
        //public static void Main(string[] args)
        //{



        //    Console.ReadKey();
        //}



        #endregion

        #region Basic Testing 

        //public static void Main(string[] args) {
        //    Program program = new Program();
        //    program.a = 10;
        //}



        #endregion
        #region Basic Testing 2

        public static void Main(string[] args)
        {
            Variance1 variance = new Variance1();
          //  variance = null;
            if (string.IsNullOrEmpty(variance.RefComponentPropValue))
            {

            }
        }



        #endregion

        #region SOLID Principle (Open and close principle, )

        #region//open and Close
        //public static void Main(string[] args)
        //{
        //    //open and Close 
        //    //open for extention , close for modification.
        //    Customer customer = new Customer();
        //    customer.InvoiceNumber = 1;
        //    CustomerNew customernew = new CustomerNew();
        //    customernew.InvoiceNumber = "sds";
        //}
        #endregion


        #endregion



        #region Object comparision or extention method
        //public static void Main(string[] args)
        //{
        //    double ? doubleValue = 10.0099877;
        //    NumberFormatInfo numberFormat = new NumberFormatInfo();
        //    //editProcedureComponentTouchCurrent
        //    //Touch Current

        //    //editProcedureComponentPatientLeakageCurrent
        //    //Patient Leakage Current
        //    string test = "cssselector:[data-aqa-id='{0}'] [class='text-right']";
        //    var data11 = string.Format(test, "editProcedureComponentTouchCurrent");
        //   // numberFormat.NumberDecimalDigits = 2;
        //   string val= string.Format("{0:F2}", doubleValue);

        //   var data = string.Format("Ui data is not matched with standard component data.Standard component details are :  \n Component Name : {0} \n Test Point name : {1} \n ", "Earch LEaage","XXXXXXX");
        //    Console.WriteLine(data);
        //    //  string val = doubleValue == null ? "" : Convert.ToDouble(doubleValue, numberFormat).ToString();

        //    Employee employee_one = new Employee();
        //    Employee employee_two = new Employee();
        //    employee_two.Id = 100;
        //    var xx = employee_one.AgeProp;
        //    employee_one.DetailedCompare(employee_two);
        //  var x=  employee_one.Id.IsValueGreaterThan(employee_two.Id);
        //}
        #endregion

        //#region Binory operation
        //public static void Main(string[] args)
        //{
        //    List<string> items = new List<string>() { "A", "A", "A" };
        //    var dif = items.Select(x => x).Distinct();
        //}
        //#endregion
    }

    public class Variance1
    {
        public string PropertyName { get; set; }
        public string UiComponentPropValue { get; set; }
        public string RefComponentPropValue { get; set; }
        public string TestPointName { get; set; }
        public string Error { get; set; }
    }

    #region Open and close principle 
    //public class Customer
    //{
    //    public int InvoiceNumber
    //    {
    //        get;
    //        set;

    //    }
    //}

    //public class CustomerNew : Customer
    //{

    //    public new string InvoiceNumber
    //    {
    //        get;
    //        set;

    //    }
    //}

    #endregion

    #region Object comparision or extention method class

    public class Employee
    {
        public int Id = 10;
        public double Age = 20.9;
        public string AgeProp { get; set; } = string.Empty;
    }
  
    public static class Extentions
    {
        public static List<Variance> DetailedCompare<T>(this T obj1, T obj2)
        {
            List<Variance> variances = new List<Variance>();
            FieldInfo[] fieldInfos = obj1.GetType().GetFields();
            PropertyInfo[] propertyInfos = obj1.GetType().GetProperties();
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                Variance variance = new Variance();
                variance.Prop = fieldInfo.Name;
                variance.ValA = fieldInfo.GetValue(obj1);
                variance.ValB = fieldInfo.GetValue(obj2);
                if (!variance.ValA.Equals(variance.ValB))
                {
                    variances.Add(variance);
                }
            }
            return variances;
        }

        public static bool IsValueGreaterThan(this int num1, int num2)
        {
            return num1 > num2;
        }
    }
   

    public class Variance
    {
        public string Prop { get; set; }
        public object ValA { get; set; }
        public object ValB { get; set; }

    }
    #endregion

}




