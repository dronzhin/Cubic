using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facet : MonoBehaviour
{
    public int[] CubesWhichFind;
    void Start()
    {
        if (transform.name == "Facet1")
        {
            CubesWhichFind = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26 };           
        }
        if (transform.name == "Facet2")
        {
            CubesWhichFind = new int [] {1, 4, 7, 10, 13, 16, 19, 22, 25};
        }
        if (transform.name == "Facet3")
        {
            CubesWhichFind = new int [] {0, 3, 6, 9, 12, 15, 18, 21, 24};
        }
        if (transform.name == "Facet4")
        {
            CubesWhichFind = new int[] { 0, 1, 2, 9, 10, 11, 18, 19, 20 };
        }
        if (transform.name == "Facet5")
        {
            CubesWhichFind = new int[] { 3, 4, 5, 12, 13, 14, 21, 22, 23 };
        }
        if (transform.name == "Facet6")
        {
            CubesWhichFind = new int[] { 6, 7, 8, 15, 16, 17, 24, 25, 26 };
        }
        if (transform.name == "Facet7")
        {
            CubesWhichFind = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        }
        if (transform.name == "Facet8")
        {
            CubesWhichFind = new int[] { 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        }
        if (transform.name == "Facet9")
        {
            CubesWhichFind = new int[] {18, 19, 20, 21, 22, 23, 24, 25, 26 };
        }
    }
}