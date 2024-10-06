using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        const string USERNAME = "Ahmed";
        const string PASSWORD = "1234";
        char[] OTP = new char[6];
    static  bool ReadInput( ref string username, ref string password)
        {
           try
          {
                Console.WriteLine("Enter User Name");
                username = Console.ReadLine();
                Console.WriteLine("Enter Passward");

                password = Console.ReadLine();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("write the password correctly");
                return false;
            }
  


       }
      static  string ReadOTP()
        {
            string OTP;
            Console.WriteLine("Enter the OTP ?");
            OTP = Console.ReadLine();   
            

            return OTP;
        }
     static   bool IscorrectPasswordAndUsername(string username, string password)
        {
            return (username == USERNAME && password == PASSWORD) ? true : false;
            }
      static  bool CheckOTP(string OTP, string OTP2)
        {
            return (OTP == OTP2) ? true : false;
        }
     
    static    void GenerateOTP()
        {
            Random random = new Random();

            string OTP = "";
            for (int i = 0; i < 6; i++) {


                OTP += random.Next(1, 10);
              
            }


            Console.WriteLine($"OTP :{OTP}");
            if (CheckOTP(OTP.ToString(),ReadOTP() ))
            {
                Console.WriteLine("End of Program");
            }
            else
            {
                Console.WriteLine("the OTP False");
            }
            
        }
       
        static void Main(string[] args)
        {
            string username="";
            string password="";
            string OTP;
            if (ReadInput(ref username, ref password))
            {

                if (IscorrectPasswordAndUsername(username, password))
                {

                    Console.WriteLine($"your userName={username},your Password {password}");


                    GenerateOTP();
                }
                else
                {
                    Console.WriteLine("the UserName or Paswerd is falser");
                }
            }

            Console.ReadKey();
        }
    }
}
