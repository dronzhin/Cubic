using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
