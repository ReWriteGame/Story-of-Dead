using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private ScoreCounter scoreCounter;




    public UnityEvent arrowCoincidedEvent;
    public UnityEvent arrowNotCoincidedEvent;

  

    public void countScore()
    {
        if (arrow1.collidedObject.GetComponent<Cell>())
        {
            if (arrow1.collidedObject.GetComponent<Cell>().Value >= 0)
                scoreCounter.add(arrow1.collidedObject.GetComponent<Cell>().Value);
            else scoreCounter.takeAway(-arrow1.collidedObject.GetComponent<Cell>().Value);

        }
    }
}
