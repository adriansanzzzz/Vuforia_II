using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evento : MonoBehaviour
{
    public float velocidadRotacion = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log("Evento encendido");
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);



        
    }
}
