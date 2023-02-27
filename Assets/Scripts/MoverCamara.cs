using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    public void MovimientoLaCamara(){

        ACalcular Temporal = GameObject.Find("ACalcular").GetComponent<ACalcular>();
        Temporal.AmoverCamara();
    }
}
