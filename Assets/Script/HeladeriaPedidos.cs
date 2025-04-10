using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaPedidos : MonoBehaviour
{

    public string SaborDeHelado;
    public int CantidadHelado;
    int Descuento;
    float PrecioHelado;

    // Start is called before the first frame update
    void Start()
    {
      if (CantidadHelado < 250 || CantidadHelado >3000)
        {
            Debug.Log("Cantidad de helado no valida");
            return;
        }
        if (SaborDeHelado != "CHO" && SaborDeHelado != "DDL" && SaborDeHelado != "FRU")
        {
            Debug.Log("Codigo no valido");
            return;
        }

        PrecioHelado = CantidadHelado * 0.5f;

        if(SaborDeHelado == "FRU")
        {
            PrecioHelado = PrecioHelado - PrecioHelado * 0.1f;
        }

        Debug.Log("Debe abonar " + PrecioHelado + " pesos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
