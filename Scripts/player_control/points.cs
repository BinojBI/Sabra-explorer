using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public static class points
    {
    
        public static int marks=0;
        public static int helloworld;

    public static void coinCollect()
        {
           marks += 1;
        
        }
    public static int display() {
        return marks;
    }
   
}

