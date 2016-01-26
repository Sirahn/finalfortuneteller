using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(WelcomeMessage);// Print welcome message here




            StartProgram(); //Start Program







            Console.Clear();
        }
                
            
        

        //** Arrays
        private static string[] ColorsArray = new string[] { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
        private static string[] TransportationMode = new string[] { "Lambo", "Yacht", "G4 Jet", "G5 Jet", "Chopper", "Boat", "Car" };
        private static string[] MonthNames = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        //** Properties
        private static string WelcomeMessage
        {
            get
            {
                return "______________________\n" +
                       "*Call Me Now, Welcome Back For Your Fortune*\n" +         //**Escaping Characters
                       
                       
                       "______________________\n";
            }
        }

        
        
        private static string getName(string FirstOrLast)   //** Method
        {
            Console.WriteLine("Please enter your " + FirstOrLast + " name:");
            getName:
            string _name = Console.ReadLine().Trim();
            if (CheckInputFor_QuitAndRestart(_name)) { return _name; }//Determines whether user wanted to quit/restart at this input point or NOT

            bool IsAValidName = true;
            if (!_name.Equals(string.Empty))
            {
                for (int i = 0; i < _name.Length; i++) //** Loop
                {
                    if (char.IsDigit(_name[i])) //** Conditions
                    {
                        IsAValidName = false;
                        break;
                    }
                }
            }
            if (_name.Equals(string.Empty) || !IsAValidName || _name.Length < 2)
            {
                Console.WriteLine("Please enter a valid " + FirstOrLast + " name:");
                goto getName; 
            }
            return _name;
        }

        static Random randomAmountInBank = new Random();

        private static bool RestartProgram = false;
        private static bool QuitProgram = false;
        private static void StartProgram()
        {
            //PART 1   START
            
            
            

            Console.WriteLine("\n- Please input required details -");

            string FirstNameValue = getName("First");
            if (CheckInputFor_QuitAndRestart(FirstNameValue)) { return; }

            string LastName = getName("Last");
            if (CheckInputFor_QuitAndRestart(LastName)) { return; }


            Console.WriteLine("\nPlease enter your age:");
            getAge:
            string _age = Console.ReadLine().Trim();
            if (CheckInputFor_QuitAndRestart(_age)) { return; }
            int AgeValue = 0;
            if (!int.TryParse(_age, out AgeValue) || AgeValue < 1 || AgeValue > 150) 
            {
                Console.WriteLine("Come on, thats crazy. Enter a real answer:");
                goto getAge;
            }


            Console.WriteLine("\nPlease enter your birth month:");
            getBirthMonth:
            string BirthMonth = Console.ReadLine().Trim();
            if (CheckInputFor_QuitAndRestart(BirthMonth)) { return; }

            bool IsAValidMonth = false;
            if (!BirthMonth.Equals(string.Empty))
            {
                for (int i = 0; i < MonthNames.Length; i++)
                {
                    if (MonthNames[i].Equals(BirthMonth, StringComparison.InvariantCultureIgnoreCase))      //** String Comparisons  & Ignoring Case 
                    {
                        IsAValidMonth = true;
                        break;
                    }
                }
            }
            if (BirthMonth.Equals(string.Empty) || !IsAValidMonth)
            {
                Console.WriteLine("Please enter a valid birth month value:");
                goto getBirthMonth;
            }


            bool AskedForHelp = false;
            getcolorAfterHelp:
            Console.WriteLine("\nPlease enter your favorite ROYGBIV color" + (AskedForHelp ? " now:" : " (Enter 'Help' to get ROYGBIV colors list):"));
            AskedForHelp = false;
            getcolor:
            string Color = Console.ReadLine().Trim();
            if (CheckInputFor_QuitAndRestart(Color)) { return; }

            bool IsAValidColor = false;
            int colorIndex = -1;
            if (!Color.Equals(string.Empty))
            {
                for (int i = 0; i < ColorsArray.Length; i++)
                {
                    if (ColorsArray[i].Equals(Color, StringComparison.InvariantCultureIgnoreCase))    //#2 ** String Comparisons  & Ignoring Case 
                    {
                        colorIndex = i;
                        IsAValidColor = true;
                        break;
                    }
                }
            }

            if (Color.Equals("Help", StringComparison.InvariantCultureIgnoreCase))
            {
                AskedForHelp = true;
                Console.WriteLine("[HELP] --- ROYGBIV colors list (separated by commas) ---");
                Console.WriteLine("    Red, Orange, Yellow, Green, Blue, Indigo and Violet\n");
                goto getcolorAfterHelp;
            }
            if (Color.Equals(string.Empty) || !IsAValidColor)
            {
                Console.WriteLine("Please enter a valid ROYGBIV color name:");
                goto getcolor;
            }

            Console.WriteLine("\nHow many siblings do you have?");
            getsib:
            string _sib = Console.ReadLine().Trim();
            if (CheckInputFor_QuitAndRestart(_sib)) { return; }
            int SiblingsValue = 0;
            if (!int.TryParse(_sib, out SiblingsValue))
            {
                Console.WriteLine("Please enter a valid 'number of siblings' value:");
                goto getsib;
            }

            
           // PART 1  END  
            
            




            
            // PART 2   START
            
            


            string _1_ageResult = string.Empty;
            if (AgeValue % 2 == 0)
            { _1_ageResult = "20 years"; }
            else { _1_ageResult = "30 years"; }

            string _2_siblingResult = string.Empty;
            switch (SiblingsValue)
            {
                case 0:
                    _2_siblingResult += "King Of Prussia";
                    break;
                case 1:
                    _2_siblingResult += "Cleveland";
                    break;
                case 2:
                    _2_siblingResult += "Camaroon";
                    break;
                case 3:
                    _2_siblingResult += "Hackensack, New Jersey";
                    break;
                default:
                    _2_siblingResult += "Virgin Islands";
                    break;
            }

            string _3_mode_of_transportation = TransportationMode[colorIndex];

            string _4_AmountInBank = string.Empty;
            string first_LetterOfBirthMonth = BirthMonth[0].ToString();
            string second_LetterOfBirthMonth = BirthMonth[1].ToString();
            string third_LetterOfBirthMonth = BirthMonth[2].ToString();

            if (FirstNameValue.IndexOf(first_LetterOfBirthMonth, StringComparison.InvariantCultureIgnoreCase) > -1
                || LastName.IndexOf(first_LetterOfBirthMonth, StringComparison.InvariantCultureIgnoreCase) > -1)
            {
                _4_AmountInBank = "$30000";
            }
            else if (FirstNameValue.IndexOf(second_LetterOfBirthMonth, StringComparison.InvariantCultureIgnoreCase) > -1
                || LastName.IndexOf(second_LetterOfBirthMonth, StringComparison.InvariantCultureIgnoreCase) > -1)
            {
                _4_AmountInBank = "$230000";
            }
            else if (FirstNameValue.IndexOf(third_LetterOfBirthMonth, StringComparison.InvariantCultureIgnoreCase) > -1
                || LastName.IndexOf(third_LetterOfBirthMonth, StringComparison.InvariantCultureIgnoreCase) > -1)
            {
                _4_AmountInBank = "$554300";
            }
            else
            {
                _4_AmountInBank = "$" + randomAmountInBank.Next(10000, 90000).ToString();
            }

            // PART 2   END  
            
            


            //PART 3   START 
            

            Console.WriteLine("\n* Result *");
            Console.WriteLine(FirstNameValue + " " + LastName + " will retire in " + _1_ageResult + " with " + _4_AmountInBank + " in the bank, a vacation home in " + _2_siblingResult + " and a " + _3_mode_of_transportation + ".");
            Console.WriteLine("*****\n");

            getTryAgainValue:
            Console.WriteLine("Would you like to try again? Please enter 'Yes' or 'No'");
            string wantToTryAgain = Console.ReadLine().Trim();
            if (CheckInputFor_QuitAndRestart(wantToTryAgain)) { return; }
            if (wantToTryAgain.Equals("yes", StringComparison.InvariantCultureIgnoreCase)
                || wantToTryAgain.Equals("'yes'", StringComparison.InvariantCultureIgnoreCase))
            {
                RestartProgram = true;
                return;
            }
            else if ((!wantToTryAgain.Equals("no", StringComparison.InvariantCultureIgnoreCase)
                && !wantToTryAgain.Equals("'no'", StringComparison.InvariantCultureIgnoreCase)) || wantToTryAgain.Equals(string.Empty))
            {
                Console.WriteLine("\nPlease provide valid input.");
                goto getTryAgainValue;
            }

           
        }




       
        private static bool CheckInputFor_QuitAndRestart(string userInput)
        {
            return false;
        }
    }
}
        
    

