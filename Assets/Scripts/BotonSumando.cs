using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonSumando : MonoBehaviour
{
    private void OnMouseDown()
    {
        ACalcular VarTEmporal = GameObject.Find("ACalcular").GetComponent<ACalcular>();
        VarTEmporal.FuncionParaSumar();

    }
}
