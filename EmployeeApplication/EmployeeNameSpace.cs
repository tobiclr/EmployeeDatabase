using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class Employee
    {

        private long textEmployeeID;
        private string textFirstname;
        private string textLastname;
        private string textPosition;

        public Employee() 
           
           {

            this.textEmployeeID = 01;
            this.textFirstname ="No First Name";
            this.textLastname = "No Last Name";
            this.textPosition = "txtPosition";
           }

    
    
            public Employee(long id, string FirstName, string LastName, string Position)
            { 
              this.textEmployeeID= id;
              this.textFirstname = FirstName;
              this.textLastname = LastName;
              this.textPosition = Position;
             }


             public long id
              {
             get 
             { 
                         
               return this.textEmployeeID;
             }
             set 
            { 
                this.textEmployeeID = value; 
            }



              }
    
            public string FirstName
            {
            get {
                return this.textFirstname; 
            }
            set { 
                this.textFirstname = value; 
            }
            
            }
    
    
            public string Lastname
        {
            get { 
                return this.textLastname; 
            }
            set { 
            this.textLastname = value;
            }



        }
    
    
    
    
            public string Position

        {
            get { 
                return this.textPosition; 
            } 
            set { 
            this.textPosition = value;
            
            }




        }
    
    
    
    
    
    }
}
