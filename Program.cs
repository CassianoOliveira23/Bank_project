class Program
{
    //Application execution starts here:
    static void Main()
    {
        //display title
        System.Console.WriteLine("==================== Msc Bank ===================");
        System.Console.WriteLine();

        System.Console.WriteLine("  Login Page ");
        System.Console.WriteLine();

        //declare variables to store username and password:
        string userName = null, password = null;


        //read userName from keyboard only if username is entered:
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        if(userName != " ")
        {
            //read password from keyboard:
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }


        //check username and password
        if(userName == "system" && password == "manager")
        {
            //declare variable to store manu choice:
            int mainMenuChoice = -1; //indicates the user has not entered any choice


            do
            {
                //show main menu:
                System.Console.WriteLine("\n::::: Main Menu :::::");
                System.Console.WriteLine();
                System.Console.WriteLine("[1] Customers");
                System.Console.WriteLine("[2] Accounts");
                System.Console.WriteLine("[3] Funds Transfer");
                System.Console.WriteLine("[4] Funds Transfer Statment");
                System.Console.WriteLine("[5] Account statement");
                System.Console.WriteLine("[0] Exit");

                //accept menu choice from keyboard
                System.Console.Write("Enter Choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                //switch-case to check manu choice:
                switch (mainMenuChoice)
                {
                    case 1: CustomerMenu();
                        break;
                    case 2: AccountsMenu();
                        break;
                    case 3: // TO DO: dispaly customer Funds Transfer
                        break;
                    case 4: // TO DO: dispaly customer Funds Transfer Statment
                        break;
                    case 5: // TO DO: dispaly customer Account statement
                        break;
                }

            } while (mainMenuChoice != 0);
           
        }


        else 
        {
            System.Console.WriteLine("Invalid Username or Passsword");
        }

        //About to exit
        System.Console.WriteLine("Thank you! Visit Again");
        System.Console.ReadKey();
    }


    static void CustomerMenu()
    {
        //variable to store customers menu choice
        int customerMenuChoice = -1;

        //do-while
        do
        {
            //print customers menu:
            System.Console.WriteLine("\n::::: Customers Menu :::::");
            System.Console.WriteLine("[1] Add Customer");
            System.Console.WriteLine("[2] Delete Customer");
            System.Console.WriteLine("[3] Update Customer");
            System.Console.WriteLine("[4] View Customer");
            System.Console.WriteLine("[0] Back to the Main Menu");

            //accept customers menu choice
            System.Console.Write("Enter Choice: ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while(customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        //variable to store accounts menu choice
        int accountsMenuChoice = -1;

        //do-while
        do
        {
            //print customers menu:
            System.Console.WriteLine("\n::::: Accounts Menu :::::");
            System.Console.WriteLine("[1] Add Account");
            System.Console.WriteLine("[2] Delete Account");
            System.Console.WriteLine("[3] Update Account");
            System.Console.WriteLine("[4] View Account");
            System.Console.WriteLine("[0] Back to the Main Menu");

            //accept customers menu choice
            System.Console.Write("Enter Choice: ");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (accountsMenuChoice != 0);

    }
}
