// method hiding
using System;
namespace MethodHidding{
    
    class Person{
        public virtual void msg(){
            Console.WriteLine("Person Msg");
        }
    }

    class Employee : Person{
        // person msg() method hidden here.
        public  void  msg(){
            Console.WriteLine("Employee Msg");
        }
    }

    class MainClass{
        public static void Main(string[] args){
            Person person = new Person();
            person.msg();
            Person empPerson = new Employee();
            empPerson.msg();
            Employee employee = new Employee();
            employee.msg();

        }
    }
}
