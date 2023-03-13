using System;

namespace ex028
{
   class Perceptron 
   {
    
      private int[2,1] num;

      Perceptron()
      {
         Num = new int[2, 1];
      }

      public int[2,1] Num 
      { 
         get 
         {
            return num;
         }
         set 
         {
            this.num = value;
         }
      }




      

  }
}