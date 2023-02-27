using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ACalcular : MonoBehaviour {
    
    int primerValor, segundoValor, Temporal, RespuestaFinal;
    public Text PrimerDigito, SegundoDigito, Signo;
    private string TempoOp, VarSigno;
    
    void Start(){

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) // para sumar
        {
            ACalcularFn("suma");
        }
        if (Input.GetKeyDown(KeyCode.R)) // para retar
        {
            ACalcularFn("resta");
        }
        if (Input.GetKeyDown(KeyCode.M)) // para mutiplicard
        {
            ACalcularFn("multiplica");
        }
        if (Input.GetKeyDown(KeyCode.D)) // para division
        {
            ACalcularFn("divide");
        }
    }

    public void FuncionParaSumar(){
        Debug.Log("FUNCIONA LA SUMA ");
    }
     public void FuncionParaRestar(){
        Debug.Log("FUNCIONA LA RESTA ");
    }
     public void FuncionParaMultiplicar(){
        Debug.Log("FUNCIONA LA MULTIPLICACIÓN ");
    }
     public void FuncionParaDividir(){
        Debug.Log("FUNCIONA LA DIVISION ");
    }
    public void AmoverCamara(){
        GameObject.Find("Main Camara").transform.position = new Vector3(10f, -0.04f,-10f);
    }

    public void ACalcularFn(string operacion){
        primerValor = Random.Range(1,10);
        segundoValor = Random.Range(1,10);

        if(primerValor-segundoValor <0)
        {
            Temporal = segundoValor;
            segundoValor = primerValor;
            primerValor = Temporal;
        }

        if(operacion=="suma"){
            RespuestaFinal = primerValor + segundoValor;
            VarSigno = "suma";
        }
        if(operacion=="resta"){
            RespuestaFinal = primerValor - segundoValor;
            VarSigno = "resta";
        }
        if(operacion=="multiplica"){
            RespuestaFinal = primerValor * segundoValor;
            VarSigno = "multiplica";
        }
        if(operacion=="divide"){
            RespuestaFinal = primerValor / segundoValor;
            VarSigno = "divide";
        }


        PrimerDigito.text = primerValor.ToString();
        SegundoDigito.text = segundoValor.ToString();

        if(VarSigno == "suma")
        {
            Signo.text = "+";
        }
        if(VarSigno == "resta")
        {
            Signo.text = "-";
        }
        if(VarSigno == "multiplica")
        {
            Signo.text = "*";
        }
        if(VarSigno == "divide")
        {
            Signo.text = "÷";
        }
        
        Debug.Log("1valor: " + primerValor + " 2valor: " + segundoValor+ " Respuesta es: "+ RespuestaFinal);

    }
    
    




}
