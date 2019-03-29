using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{
    public string nombre;
    public GameObject sol;
    public float speed;
    public float radio;
    public float angulo;
    // Start is called before the first frame update
    void Start()
    {
        angulo = 0;
        radio = transform.position.x;
        Debug.Log("Nombre: " + nombre);
    }

    // Update is called once per frame
    void Update()
    {
        angulo += speed*Time.deltaTime;
        transform.position =new Vector3 ( 0, radio * Mathf.Cos(angulo), radio * Mathf.Sin(angulo) );

    }
}
