using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio1_operacoesAritmeticas_somar : MonoBehaviour
{
    public Vector2 v1 = new Vector2(0, 0);
    public Vector2 v2 = new Vector2(1, 1);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            Evaluate("Soma", v1 + v2, Somar(v1, v2));

   
    }

    private void Evaluate(string opName, Vector2 expected, Vector2 calculated)
    {
       
        Debug.LogFormat("Operação {0} é {1}", opName, calculated);
       
    }

    Vector2 Somar(Vector2 a, Vector2 b)
    {
        return new Vector2(a.x + b.x, a.y + b.y);
    }

}
