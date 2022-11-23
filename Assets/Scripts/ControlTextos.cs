using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlTextos : MonoBehaviour
{
    [SerializeField] PlantillaTextos plantilla;
    [SerializeField] PlantillaTextos[] arrayPlantillas;

    [SerializeField] TextMeshProUGUI textoNarracion;
    [SerializeField] TextMeshProUGUI textoRespuestaUno;
    [SerializeField] TextMeshProUGUI textoRespuestaDos;
    //[SerializeField] TextMeshProUGUI textoRespuestaTres;
    
    [SerializeField] GameObject[] arrayBotones;

    

    // Start is called before the first frame update
    private void Start()
    {
        plantilla = arrayPlantillas[0];
        muestraTexto();
    }

    void muestraTexto(){
        textoNarracion.text= plantilla.textoNarrativo;
        textoRespuestaUno.text = plantilla.respuestaUno;
        textoRespuestaDos.text = plantilla.respuestaDos;
        //textoRespuestaTres.text = plantilla.respuestaTres;
        
    }

    public void controlBotones(int indice){
        plantilla = arrayPlantillas[plantilla.arrayReferencias[indice]];
        muestraTexto();
    }

    void DesactivarBotones(){
        foreach(var boton in arrayBotones){
            boton.SetActive(false);
        }
    }

}
