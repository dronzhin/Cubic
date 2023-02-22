using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CODE-REVIEW: предалагаю переимновать класс в GenerationCube или в ElementsOfCubicRubic
public static class ArrayCubes
{
    // CODE-REVIEW: это у нас hard-code. предлагаю избавиться от этого и сделать генерацию через циклы
    public static GameObject[] cubes =
    {
        GameObject.Find("Cube 1-1-1"), 
        GameObject.Find("Cube 1-1-2"), 
        GameObject.Find("Cube 1-1-3"), 
        GameObject.Find("Cube 1-2-1"),
        GameObject.Find("Cube 1-2-2"),
        GameObject.Find("Cube 1-2-3"),
        GameObject.Find("Cube 1-3-1"),
        GameObject.Find("Cube 1-3-2"),
        GameObject.Find("Cube 1-3-3"),
        GameObject.Find("Cube 2-1-1"),
        GameObject.Find("Cube 2-1-2"),
        GameObject.Find("Cube 2-1-3"),
        GameObject.Find("Cube 2-2-1"),
        GameObject.Find("Cube 2-2-2"),
        GameObject.Find("Cube 2-2-3"),
        GameObject.Find("Cube 2-3-1"),
        GameObject.Find("Cube 2-3-2"),
        GameObject.Find("Cube 2-3-3"),
        GameObject.Find("Cube 3-1-1"),
        GameObject.Find("Cube 3-1-2"),
        GameObject.Find("Cube 3-1-3"),
        GameObject.Find("Cube 3-2-1"),
        GameObject.Find("Cube 3-2-2"),
        GameObject.Find("Cube 3-2-3"),
        GameObject.Find("Cube 3-3-1"),
        GameObject.Find("Cube 3-3-2"),
        GameObject.Find("Cube 3-3-3")
    };
}
