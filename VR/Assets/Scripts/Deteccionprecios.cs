using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Deteccionprecios : MonoBehaviour
{
    public TextMeshPro pantalla;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Producto")
        {
            int productoScaneado = collision.gameObject.GetComponent<Datos>().precio;
            pantalla.text = productoScaneado.ToString();
            Debug.Log(productoScaneado);

        }
    }
}
