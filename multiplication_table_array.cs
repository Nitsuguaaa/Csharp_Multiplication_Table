using System;
class table {
    static int[,] mtable = new int[10,10];
    static void Main() {
        marray();

        for (int i = 0; i < mtable.GetLength(0); i++) {      
            for (int j = 0; j < mtable.GetLength(1); j++) {      
                Console.Write("{0}\t", mtable[i, j]);     
            }      
            Console.WriteLine("\n");      
        } 
    }

    static void marray() {
        for(int i = 1; i <= 10; i++) {
            for(int j = 1; j <= 10; j++) {
                mtable[i - 1, j - 1] = i * j;
            }
        }
    }
}