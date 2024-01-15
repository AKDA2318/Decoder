using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder {
    internal class Program {
        static void Main(string[] args) {
            string decodedMessage= Decode.decode("coding_qual_input.txt");
            Console.WriteLine(decodedMessage);
            Console.ReadKey();

        }
    }
}
