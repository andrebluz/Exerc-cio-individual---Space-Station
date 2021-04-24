using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AGENTMANAGER : MonoBehaviour
{
    GameObject[] allAgents;
    void Start()
    {
        //array contém objetos com a tag AI
        allAgents = GameObject.FindGameObjectsWithTag("AI");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //cria variavel hit do tipo raycast
            RaycastHit hit;

            //se a conversão do posicionamento da tela para Raycast for menor de 155 unidades, retorna o valor para o raycast hit criado anteriormente
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 155))
            {
                //para cada objeto dentro do array da linha 7
                foreach (GameObject a in allAgents)
                    //setdestination para o raycast .point
                    a.GetComponent<AICONTROL>().agent.SetDestination(hit.point);

            }
        }
    }
}
