using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birth_of_a_Computer
{
    class MotherBoard
    {
        public RAM ram;


        //member variables - Has A
         public string Manufacturer;
         public CPU Processor;
         public RAM TemporaryMemory;
         public HardDrive Storage;
         public GPU Graphics;
         private HardDrive hardDrive;

        //constructor - Spawner

        public Motherboard(string manufacturer, CPU cpu, RAM ram, HardDrive harddrive, GPU gpu)
        {
            RAM RAM = new RAM(63.9, "CooCooCaChoo");
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;
        }

            
         
     }   
        
        
        
        
        
        
        
        
}

    
       




    



        //member methods - Can Do

    

    

