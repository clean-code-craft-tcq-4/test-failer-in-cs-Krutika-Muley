using System;
using System.Diagnostics;

namespace AlerterSpace
{
    class Alerter
    {
        static int alertFailureCount = 0;
        static int networkAlertStub(float celcius)
        {
            if (celcius >200)
            {
                Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
                return 500;
            }
            else
            {
                return 200;
            }
        }
        
          static int networkAlert(float celcius)
        {
         //production code 
              return 0;
        }
        static void alertInCelcius(float farenheit)
        {
            float celcius = (farenheit - 32) * 5 / 9;
#if DEBUG
                int returnCode = networkAlertStub(celcius);
  #endif
#if !DEBUG
                int returnCode = networkAlert(celcius);
#endif
            if (returnCode != 200)
            {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 0;
            }
        }
        static void Main(string[] args)
        {
            alertInCelcius(400.5f);
            alertInCelcius(303.6f);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Debug.Assert(alertFailureCount.Equals(1));
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}
