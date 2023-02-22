using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CODE-REVIEW: ����� ������ �� ���������� ����� ���������� 1 ������ ArrowButton � ������� ���� �� ����������� ��� ������
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
