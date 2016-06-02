﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for the driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // create instance of the Student class
            Student tommy = new Student("Tommy", 20, "S123456789");
            tommy.SaysHello();

            Console.WriteLine();

            tommy.Studies();

            Console.WriteLine();

            // create instance of the Teacher class
            Teacher tom = new Teacher("Tom", 47, "T123456789");
            tom.SaysHello();

            Console.WriteLine();

            tom.Teaches();


        }
    }
}
