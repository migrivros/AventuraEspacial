using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollowerUpgraded : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints;
    private int currentWayPointIndex = 0;
    private bool avanza = true;             //Usaremos este condicional para avanzar o retroceder progresivamente sobre los puntos.

    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        if(Vector2.Distance(waypoints[currentWayPointIndex].transform.position, transform.position) < .1f)   //Si el objeto está llegando al punto, cambiamos su direccion de movimiento.
        {
            //Comprobamos si el elemento avanza o retrocede
            if(avanza == true)
            {
                currentWayPointIndex++;
                if(currentWayPointIndex >= waypoints.Length)
                {
                    avanza = false;
                    currentWayPointIndex--;
                }
            }
            else
            {
                currentWayPointIndex--;
                if(currentWayPointIndex <= 0)
                {
                    avanza = true;
                }
            }
            
        }
        transform.position =  Vector2.MoveTowards(transform.position, waypoints[currentWayPointIndex].transform.position, Time.deltaTime * speed); //Realizamos el movimiento del elemento hasta el nuevo punto.
    }
}
