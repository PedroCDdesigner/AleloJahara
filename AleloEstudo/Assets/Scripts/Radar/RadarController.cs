using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarController : MonoBehaviour {

    //static variables over which the Slices' and Quadrants' animations are updated
    public static string currentSlice;
    public static string quadrantName;

    public void SliceSelect(string name)
    {
        currentSlice = name;
        //print("the name of the current Slice is: " + name); //Debug
    }

    //CurrentSlice Getter
    public string getCurrentSlice()
    {
        return currentSlice;
    }

    //QuadrantName Getter
    public string getquadrantName()
    {
        return quadrantName;
    }

    //QuadrantName Setter
    public void setquadrantName(string name)
    {
        quadrantName = name;
    }
    void Start ()
    {
		
	}
	

	void Update ()
    {
		
	}
}
