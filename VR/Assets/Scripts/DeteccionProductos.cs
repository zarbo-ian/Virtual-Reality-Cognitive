using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteccionProductos : MonoBehaviour
{
    public string Item1;
    public string Item2;
    public string Item3;
    public string Item4;

    public Text Texto1;
    public Text Texto2;
    public Text Texto3;
    public Text Texto4;


    private void Update()
    {

        Texto1.text = Item1;
        Texto2.text = Item2;
        Texto3.text = Item3;
        Texto4.text = Item4;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Producto")
        {
            string productoMetido = collision.gameObject.GetComponent<Datos>().Nombre;
            if (productoMetido == Item1)
            {
                Item1 = "";
                Debug.Log("Coinciden");
            }
            if (productoMetido == Item2)
            {
                Item2 = "";
            }
            if (productoMetido == Item3)
            {
                Item3 = "";
            }
            if (productoMetido == Item4)
            {
                Item4 = "";
            }
            
        }
    }
}
