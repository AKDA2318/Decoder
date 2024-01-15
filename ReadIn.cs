using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Decoder {
    internal static class ReadIn {
        public static Data ReadTheFileIn(string FileName) {// just a simple data read class 
            string temp;// for temperary valuables
            string[] tempArr;// for temperary arrays
            StreamReader sr = new StreamReader(FileName); // the object of the streamReader
            List<int> ints = new List<int>();
            List<string> strings = new List<string>();// the 2 lis to hold the datas
            while (!sr.EndOfStream) {
                temp = sr.ReadLine();
                tempArr = temp.Split(' ');
                ints.Add(Convert.ToInt32( tempArr[0]));
                strings.Add(tempArr[1]);// just a simple method to read all lines in use the temp to store, split it into the temparr and put the element into the correct list
            }
            
            Data DataIn = new Data(ints,strings);//create the obj and return it
            return DataIn;
        }
    }
}
