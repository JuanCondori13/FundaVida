using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonMultiplicando : MonoBehaviour
{
    private void OnMouseDown()
    {
        ACalcular VarTEmporal = GameObject.Find("ACalcular").GetComponent<ACalcular>();
        VarTEmporal.FuncionParaMultiplicar();

    }
}
