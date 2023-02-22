using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;
using Vector3 = UnityEngine.Vector3;

// CODE-REVIEW: предлагаю перменовть класс в ArrowButton который бы обрабатывал нажатия на себя
public class ArrowUpMouseDown : MonoBehaviour
{
    [SerializeField] private GameObject facet;
    [SerializeField] private GameObject cubes;
    private Facet currentFacet;
    private bool isNotClicker = true;
    private int corner = 0;

    void OnMouseUp()
    {
        currentFacet = facet.GetComponent<Facet>();
        int lengthFindCubes = currentFacet.CubesWhichFind.Length;
        for (int i = 0; i < lengthFindCubes; i++)
        {
            ArrayCubes.cubes[currentFacet.CubesWhichFind[i]].transform.SetParent(facet.transform);
            Debug.Log(string.Join(" ", currentFacet.CubesWhichFind));
        }
        isNotClicker = false;
        
    }

    // CODE-REVIEW: закомментированный код удаляется
    //void Update()
    //{
    //    if (isNotClicker) return;
    //    string nameFacet = transform.name;
    //    if (nameFacet.Contains("Up"))
    //    {
    //        facet.transform.Rotate(new Vector3(90f, 0, 0));
    //        ArrayCubes.cubes = ChangeCubesArrowUp(ArrayCubes.cubes, currentFacet.CubesWhichFind);
    //        isNotClicker = true;

    //    }
    //    else
    //    {
    //        facet.transform.Rotate(-90f, 0f, 0f);
    //        ArrayCubes.cubes = ChangeCubesArrowDown(ArrayCubes.cubes, currentFacet.CubesWhichFind);
    //        isNotClicker = true;
    //    }
    //    if (isNotClicker)
    //    {
    //        int lengthFindCubes = currentFacet.CubesWhichFind.Length;
    //        for (int i = 0; i < lengthFindCubes; i++)
    //        {
    //            ArrayCubes.cubes[currentFacet.CubesWhichFind[i]].transform.SetParent(cubes.transform);
    //        }
    //    }
    //}

    void Update()
    {
        if (isNotClicker) return;
        string nameFacet = transform.name;
        if (nameFacet.Contains("Up"))
        {
            //facet.transform.localRotation = UnityEngine.Quaternion.Euler(corner, 0, 0);
            facet.transform.Rotate(new Vector3(0.2f, 0, 0));
        }
        else
        {
            facet.transform.Rotate(-0.2f, 0f, 0f);
        }

        corner += 2;
        int lengthFindCubes = currentFacet.CubesWhichFind.Length;
        if (corner == 900)
        {
            for (int i = 0; i < lengthFindCubes; i++)
            {
                ArrayCubes.cubes[currentFacet.CubesWhichFind[i]].transform.SetParent(cubes.transform);
            }
            isNotClicker = true;
            if (nameFacet.Contains("Up"))
            {
                ArrayCubes.cubes = ChangeCubesArrowUp(ArrayCubes.cubes, currentFacet.CubesWhichFind);
            }
            else
            {
                ArrayCubes.cubes = ChangeCubesArrowDown(ArrayCubes.cubes, currentFacet.CubesWhichFind);
            }
            corner = 0;
        }
    }

    // CODE-REVIEW: hard-code - желательно избавиться
    private GameObject[] ChangeCubesArrowUp(GameObject[] arrayCubes, int[] changeCubes)
    {
        GameObject saveObject;
        saveObject = arrayCubes[changeCubes[0]];
        arrayCubes[changeCubes[0]] = arrayCubes[changeCubes[6]];
        arrayCubes[changeCubes[6]] = arrayCubes[changeCubes[8]];
        arrayCubes[changeCubes[8]] = arrayCubes[changeCubes[2]];
        arrayCubes[changeCubes[2]] = saveObject;
        saveObject = arrayCubes[changeCubes[1]];
        arrayCubes[changeCubes[1]] = arrayCubes[changeCubes[3]];
        arrayCubes[changeCubes[3]] = arrayCubes[changeCubes[7]];
        arrayCubes[changeCubes[7]] = arrayCubes[changeCubes[5]];
        arrayCubes[changeCubes[5]] = saveObject;
        return arrayCubes;
    }

    // CODE-REVIEW: hard-code - желательно избавиться
    private GameObject[] ChangeCubesArrowDown(GameObject[] arrayCubes, int[] changeCubes)
    {
        GameObject saveObject;
        saveObject = arrayCubes[changeCubes[0]];
        arrayCubes[changeCubes[0]] = arrayCubes[changeCubes[2]];
        arrayCubes[changeCubes[2]] = arrayCubes[changeCubes[8]];
        arrayCubes[changeCubes[8]] = arrayCubes[changeCubes[6]];
        arrayCubes[changeCubes[6]] = saveObject;
        saveObject = arrayCubes[changeCubes[1]];
        arrayCubes[changeCubes[1]] = arrayCubes[changeCubes[5]];
        arrayCubes[changeCubes[5]] = arrayCubes[changeCubes[7]];
        arrayCubes[changeCubes[7]] = arrayCubes[changeCubes[3]];
        arrayCubes[changeCubes[3]] = saveObject;
        return arrayCubes;
    }
}
