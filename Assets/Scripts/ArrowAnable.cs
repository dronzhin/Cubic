using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CODE-REVIEW: очень похоже на избыточный класс достаточно 1 класса ArrowButton в котором были бы реализованы эти методы
public class ArrowAnable : MonoBehaviour
{
    void OnMouseEnter()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }
    void OnMouseExit()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
