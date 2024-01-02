using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetector : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public Canvas BattleCanvas;
    public Canvas ChatCanvas;

    private void Start()
    {
        BattleCanvas.enabled = false;
    }

    private void Update()
    {
        if (BattleCanvas.enabled == true) 
        { 
            playerMovement.moveSpeed = 0;
        }
        else { playerMovement.moveSpeed = 5; }    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BattlePoint"))
        {
            BattleCanvas.enabled = true;
        }

        if (collision.gameObject.CompareTag("Person"))
        {
            ChatCanvas.enabled = true;
        }
    }
}
