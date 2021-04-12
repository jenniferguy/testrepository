using System;

namespace Speeding_Violation_Calculator_Input_Validation {
    class Program {
        static void Main(string[] args) {
            //DECLARE VARIABLES
            int speedLimit = 0;
            int driverSpeed = 0;

            //VALIDATION LOOP CONDITIONS FOR SPEED LIMIT
          do{
                 //ASK FOR SPEED LIMIT
                    speedLimit = PromptInt(" What is the speed limit? ");

                    if (speedLimit < 20 || speedLimit > 70) {
                        Console.WriteLine(" ERROR: Enter a valid speed between 20 and 70.");
                    }//END IF

            } while (speedLimit < 20 || speedLimit > 70);

            //VALIDATION LOOP CONDITION FOR DRIVER SPEED
            do { 
                //ASK FOR DRIVER SPEED
                    driverSpeed = PromptInt(" What is your current speed ");

                    if (driverSpeed < speedLimit) {
                        Console.WriteLine(" ERROR: Enter a driving speed equal to or greater than speed limit. ");
                    }//END IF

            } while (driverSpeed < speedLimit);

                //DISPLAY MPH OVER SPEED LIMIT
                       Console.WriteLine(" MPH over = {0}", Show_MPH_Over(driverSpeed, speedLimit));
        }//END MAIN


        // FUNCTION TO SHOW MPH
        static int Show_MPH_Over ( int driverSpeed, int speedLimit) {
                int MPH_Over = driverSpeed - speedLimit;
                return MPH_Over;
        }//END FUNCTION

        //FUNCTION FOR USERINPUT
        static int PromptInt(string text){
                Console.Write(text + " ");
                return int.Parse(Console.ReadLine());
        }//END FUNCTION
    }//END CLASS
}//END NAMESPACE
