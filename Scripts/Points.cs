using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {

	// Use this for initialization
public static int point = 0;

public static int getMarks (){
for(int x=1; x<16;x++){
point += x;
}
return point;
}
}
