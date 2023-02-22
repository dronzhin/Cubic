using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    // Start is called before the first frame update
    // CODE-REVIEW: хорошее именование переменных
    private float speedRotate = 0.5f;
    private float horisoltalInput;
    private float verticalInput;

    // CODE-REVIEW: не забываем про модификаторы доступа
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horisoltalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * speedRotate * horisoltalInput);
        transform.Rotate(Vector3.left * speedRotate * verticalInput);
    }
}
