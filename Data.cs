using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder {
    internal class Data {//In this Data class I can store the organized an Unorganized data as well
        public Data(List<int> order, List<string> words) {
            Order = order;
            Words = words;
            
        }

        public List<int> Order { get; set; }
        public List<string> Words { get; set; }

        
    }
}
