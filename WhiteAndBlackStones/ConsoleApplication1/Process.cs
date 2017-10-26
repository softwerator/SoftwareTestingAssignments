using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Process
    {
        public int IntValue { get; set; }
        public string BinaryValue { get; set; }
        public List<char[]> TrueList { get; set; } = new List<char[]>();
        public List<char[]> TryList { get; set; } = new List<char[]>();
        public int LoopVariable = 0;
        public int NumLength = 0;
        public char[] TempBinary;
        
        public void AddItem(int value)
        {
            NumLength = Convert.ToInt32(Math.Log(value, 2));
            for (int i = (value/2); i < value; i++)
            {
                var binary = ConvertBinary(i);
                TempBinary = binary.ToCharArray();
                for (int j = 0; j < TempBinary.Length; j++)
                {
                    if (TempBinary[j] == '1') { TempBinary[j] = 'B'; }
                    else if (TempBinary[j] == '0') { TempBinary[j] = 'S'; }
                }
                TryList.Add(TempBinary);
                SplitString(TryList[LoopVariable]);
                LoopVariable++;
            }
        }

        public void SplitString(char[] binaryCharArray)
        {
            int control = 0;
            for (int i = 0; i < NumLength; i++)
            {
                if (i == (NumLength-1)) break;
                if (!(binaryCharArray[i] == 'S' && binaryCharArray[i + 1] == 'S')) { control = 1; }
                else { control = 0; break; }
            }
            if (control == 1)
                TrueList.Add(binaryCharArray);
            if (NumLength == 1)
                TrueList.Add(binaryCharArray);
        }

        public string ConvertBinary(int value)
        {
            string binary = Convert.ToString(value, 2);
            return binary;
        }
    }
}
