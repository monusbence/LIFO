using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class USET
    {
        public String[] array;
        public int length = 0;

        public override string? ToString()
        {
            String result = "";
            for (int i = 0; i<length; i++) 
            {
                result += array[i] + ";";
            }
            return result;
        }

        public USET():this(50) 
        {
        
        }

        public USET(int capacity) 
        {
            array = new String[capacity];
        }

        public void Push(String name)
        {
            if (length == array.Length)
            {
                throw new Exception("Betelt a FIFO! Queue overflow!");
            }

            for (int index = 0; index < length; index++)
            {
                if (array[index] == name)
                {
                    array[index] = array[length];
                    return;
                    //van mit törölni
                }
                index++;
            }
            array[length] = name;
            ++length;
        }

        public void Remove(String name)
        {
            if (length == 0)
            {
                throw new Exception($"Üres halmazból nem lehet törölni a {name} értékét!");
            }

            
            for (int index = 0; index < length; index++ )
            {
                if (array[index] == name) 
                {
                    array[index] = array[length];
                    return;
                    //van mit törölni
                }
                index++;
            }
            throw new Exception($"A {name} érték nem szerepel a halmazban!");
            
        }
        public void Clear()
        {
            length = 0;
        }

        public int Length => length;
        public int Capacity => array.Length;

    }
}
