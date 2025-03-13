using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300126
{
    class FanLaptop{
        enum State {Turbo , Balance};

        public void TurnOn()
        {
            State state = State.Balance;
            String[] status = { "Turn On", "Turn Off" };

            while (state != State.Turbo) {
                Console.WriteLine("\n" + "fan" + status[(int)state] + "\n");
                Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                string input = Console.ReadLine();

                switch (state) {
                    case State.Balance:
                        if (input == "1")
                        {
                            state = State.Turbo;
                        }
                        break;
                    case State.Turbo:
                        if (input == "2")
                        {
                            state = State.Balance;
                        }
                        else if ( input == "exit") {
                            Program.Main();
                        }
                        break;

                }

            }
        }
    }
}
