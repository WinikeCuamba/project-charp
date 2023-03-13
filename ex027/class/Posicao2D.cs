using System;

namespace ex027
{
   public class Posicao2D
   {
      public Posicao2D()
      {
         this.X = Convert.ToByte(DARK_POSITION);
         this.Y = Convert.ToByte(DARK_POSITION);
      }
      public Posicao2D(byte x, byte y)
      {
         this.X = x;
         this.Y = y;
      }

      public const short DARK_POSITION = 10;

      public byte X { get; set; }
      public byte Y { get; set; }
   }
}

