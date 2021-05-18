// Alonzo Stephens
// IT112
// NOTES: (This is what I had.) <- This was my original note but I tuned in today and got clarity on the behaviors below.
// Originally I had the two sub classes inheriting from base class and the constructors on all the classes.
// I also had a dial method that didn't really do any but return "Dialing Company name ......" but after today I realized I was over complicating the project.

// BEHAVIORS NOT IMPLIMENTED AND WHY: Actually implementing the data into an array was giving me trouble <- OLD   
using System;

namespace Stephens_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] dialerList = new Phone[11];
            dialerList[0] = new HomePhone("CompuTest", "(303) 985-5060", 1);
            dialerList[1] = new CellPhone("Curtis Manufacturing", "(603) 532-4123", 2);
            dialerList[2] = new HomePhone("Data Functions", "(800) 876-2524", 1);
            dialerList[3] = new HomePhone("Donnay Repair", "(708) 397-3330", 1);
            dialerList[4] = new HomePhone("ErgoNomic Inc", "(360) 434-3894", 1);
            dialerList[5] = new HomePhone("ErgoSource", "(800) 969-4374", 1);
            dialerList[6] = new CellPhone("Fox Bay Industries", "(800) 874 - 8527", 2);
            dialerList[7] = new CellPhone("Glare-Guard", "(800) 545-6254", 2);
            dialerList[8] = new CellPhone("Hazard Comm Specialists", "(407) 783-6641", 2);
            dialerList[9] = new CellPhone("Komfort Support", "(714) 472-4409", 2);

            for (int i = 0; i < 11; i++)
                Console.WriteLine(dialerList[i].Dial());
        }
    }
}
