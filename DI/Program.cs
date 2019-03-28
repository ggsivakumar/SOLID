using System;

namespace DI
{
    class Program
    {
        //S is single responsibility principle(SRP)
        //O stands for open closed principle(OCP)
        //L Liskov substitution principle(LSP)
        //I interface segregation principle(ISP)
        //D Dependency injection principle(DIP)
        static void Main(string[] args)
        {


            //ConstructorInjection
            ConstructorInjection.IEmailService EmailServiceCI = new ConstructorInjection.GmailService();
            ConstructorInjection.BusinessLogic businessLogicCI = new ConstructorInjection.BusinessLogic(new object(), EmailServiceCI);

            //MethodInjection
            MethodInjection.IEmailService EmailServiceMI = new MethodInjection.GmailService();
            MethodInjection.BusinessLogic businessLogicMI = new MethodInjection.BusinessLogic(new object());
            businessLogicMI.RegisterUser(EmailServiceMI);

            //SetterInjection
            SetterInjection.IEmailService EmailServiceSI = new SetterInjection.GmailService();
            SetterInjection.BusinessLogic businessLogicSI = new SetterInjection.BusinessLogic(new object());
            businessLogicSI.EmailService = EmailServiceSI;
            businessLogicSI.RegisterUser();
        }

        //SRP
        /*The Single Responsibility Principle (SRP) 
        states that a class should have only one reason to Single Responsibility changes. */

        //OCP
        /*(The Open-Closed Principle(OCP) states that software entities(classes, modules, methods, etc.) 
        OpenClosedPrincipleshould be open for extension, but closed for modification) */

        //LSP
        /*The Liskov Substitution Principle (LSP) states thatLiskovSubstitution 
        subtypes must be substitutable for their base types. */

        //ISP
        /*The Interface Segregation Principle (ISP) states that clients 
        should not be forced to depend on methods that they do not use */

        //DI
        /*high level modules should not depend on low level modules; both should depend on abstractions. 
        Abstractions should not depend on details.  Details should depend upon abstractions.*/
    }
}
