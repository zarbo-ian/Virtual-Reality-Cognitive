using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionProductos : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Carrito")
        {
            Debug.Log(gameObject.tag);
            Destroy(gameObject);
        }
    }
}
