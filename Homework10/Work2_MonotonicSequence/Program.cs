using System;

namespace Work2_MonotonicSequence
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number = 20;
            MonoSeq(number);

            void MonoSeq(int countAll, int currNum = 1, int countNum = 0)
            {
                if (countAll == 0)   return;

                countAll--;
                countNum++;
                
                if (countNum > currNum)
                {
                    currNum++;
                    countNum = 1;
                }

                Console.Write(currNum +"\t");
                MonoSeq(countAll, currNum, countNum);
            }
            Console.WriteLine();
        }
    }
}