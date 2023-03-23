using System;

namespace Power2Method
{
    class Program
    {
        public static void PowersOf2UntilN(int n){

            for(int i =1; i<=(1<<n);i=i<<1)
            {
                Console.WriteLine(i);
            }


        }
        public static void PowersOf2Until5()
        {
            for(int i=1;i<=(1 << 5);i << 1){
               Console.WriteLine(i);
            }
            
        }
        static void Main(string[] args)
        {
            int n=0;
            PowersOf2Until5();
            PowersOf2Until5();

            PowersOf2UntilN(n);
            PowersOf2UntilN(n+1);
        }
    }
}
