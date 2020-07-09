using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace INTEL8080
{
    public class Functions
    {
        public ushort[] arrayOriginal = new ushort[4] { 0xfd35, 0x4967, 0xd192, 0x7b80 };
        public ushort[] array = new ushort[4] { 0xfd35, 0x4967, 0xd192, 0x7b80 };
        public void ADD(int to, int from)
        {
            array[to] += array[from];
        }

        public void MOV(int to, int from)
        {
            array[to] = array[from];
        }

        public void SWAP(int to, int from)
        {
            ushort temporal = array[to];
            array[to] = array[from];
            array[from] = temporal;

        }

        public void CHANGE(int to,ushort number)
        {
            array[to] = number;
        }
    }
}
