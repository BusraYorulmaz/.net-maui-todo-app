using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //OPEN CLOSED PRINCIPLE
    //YAZILIMA YENİ BİR ÖZELLİK EKLENİYORSA MEVCUT HİÇBİR KODA DOKUNMA
    class Program
    {
        static void Main(string[] args)
        {
           UserTest();
          // ToDoListTest();

        }

        private static void ToDoListTest()
        {
            ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());

            foreach (var todolist in toDoListManager.GetAll())
            {
                Console.WriteLine(todolist.ToDoListTitle);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetUserToDoDetails();

            if (result.Success==true) 
            {
                foreach (var user in result.Data ) //  GetAll , GetAllByUserId(2)  ,  GetAllByEmail("by@gmail.com") ,GetAllByEmail("by@gmail.com")
                {
                    Console.WriteLine(user.UserName + "/" + user.ToDoListTitle);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
