using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* Author: Meer Zaheen Nazmul
* Date:May 17, 2016
* Date Modified: May 17, 2016
* Description: Advanced Method Demo Lesson 2
* Version: 0.0.3 - Added addXandY method and associated test
*/

namespace COMP123_s2016_Lesson2
{
    /**
    * Main Driver Class for Lesson 2
    * 
    * @class Program
    */
    public class Program
    {
        /**
        * Main method for our driver class
        *
        * @constructior main
        * @param {string[]} args
        */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;

            result = addXandY(x, y);
            Console.WriteLine(result);
        }
        
        /** 
        * Simple method to add two values
        * 
        * @method addXandY
        * @param {int} firstNumber
        * @param {int} secondNumber
        */
        public static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result =  firstNumber + secondNumber;
            return result;
        }

        public static void addXtoY(ref int x, ref int Y)
    }
}
