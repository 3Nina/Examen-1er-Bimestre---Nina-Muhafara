using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaDeTaxis : MonoBehaviour
{
    // Declaracion de variables
    public int cantidadDeDias;
    public int cantidadDeTaxis;

    float costoPorLitro = 130f;
    int kmPorLitro = 15;
    int cantTotalLitros;
    float costoTotal;
    int kmPorDia = 90;
    int kmTotalPorDia;

    float descuentoCienLitros = 20f;
    float plataDescontada;
    int litrosParaDescuento = 100;
    float costoTotalConDescueto;


    void Start()
    {
        //2. Ingreso de datos (más adelante)
        if (cantidadDeDias < 5 || cantidadDeTaxis < 1)
        {
            Debug.Log("Cantidad no válida");
            return;
        }

        //3. Procesamiento de datos
        kmTotalPorDia = kmPorDia * cantidadDeDias * cantidadDeTaxis;

        cantTotalLitros = kmTotalPorDia / kmPorLitro;
        if (kmTotalPorDia % kmPorLitro != 0)
        {
            cantTotalLitros++;
        }

        costoTotal = cantTotalLitros * costoPorLitro;

        if (cantTotalLitros < litrosParaDescuento)
        {
            Debug.Log("No alcanza para el descuento");
            
        } else
        {
            plataDescontada = costoTotal * descuentoCienLitros / 100;
            costoTotalConDescueto = costoTotal - plataDescontada;
            Debug.Log("La cantidad descontada son: " + plataDescontada + "y el costo total es: " + costoTotalConDescueto);
        }

        //4. Mostrar el resultado
        Debug.Log("Una flota de " + cantidadDeTaxis + " unidades trabajando durante " + cantidadDeDias + " implicará un gasto de " + costoTotal + " pesos en concepto de combustible");


    }


    void Update()
    {
        
    }
}
