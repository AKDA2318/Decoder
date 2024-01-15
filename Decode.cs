using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder {
    internal static class Decode {//As the task said the in file is the same and it reads in all the data. 
        public static string decode(string message_file) {
            Data DataIn = ReadIn.ReadTheFileIn(message_file);//data read
             var Rows = DataIn.Order.Zip(DataIn.Words, (order, words) => (Id: order, Word: words)).ToList();//Here I make a combined list what i can sort easily like an sql statemant
            Rows.Sort((a,b)=> a.Id.CompareTo(b.Id));// sorting by id
            DataIn.Order = Rows.Select(row => row.Id).ToList();//reload the data with the sorted data
            DataIn.Words = Rows.Select(row=> row.Word).ToList();
            int neededWordsNumber = 3; //This var is for to see how many words do we want.
            int index = 0; // this var is to track which layer is the current
            int currentj = 0; // the second for's end value
            int Jstarter = 0; //the second for's starter value. I have 2 because i don't want an infinite loop but i need them for counting
            string returnString = "";
           /* for (int i = 0; i < 10; i++) {
                Console.WriteLine($"{DataIn.Order[i]} {DataIn.Words[i]}");
            }*/ //this code only for debugging
            /*
             *  save the correct word we need to tknow what is our layer, and the starter I choose this approach because with this i have only one for and i don't have to include the first element manually
             *  jstarter is like 0 and index is 0 too soo it finds the first index.
             *  in the inner for the cycle runs till reaches the starter+index
             *  
             * 
             * */
            for (int i = 0; i < neededWordsNumber; i++) {
                returnString += " " + DataIn.Words[(Jstarter + index)];
                index++;
                for (int j = Jstarter; j <= (index+Jstarter); j++) {
                    if (j>currentj) {
                        currentj = j;
                    }
                }
                Jstarter = currentj;
                
            }
            return returnString;
        }
    }
}
