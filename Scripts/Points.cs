using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public static class Points
    {
    public static float  total=0f;
        public static float marks=0f;
        
    public static void coinCollect(float point)
        {
           marks += point;
        
        }
    public static float display() {
        return marks;
    }
  
}
