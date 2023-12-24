using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetector : MonoBehaviour
{
    public NonBattleUI nonBattleUI;
    public PlayerMovement playerMovement;

    public Canvas nonBattleCanvas;
    public Canvas BattleCanvas;

    private void Start()
    {
        BattleCanvas.enabled = false;
        nonBattleCanvas.enabled = true;
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
        if (collision.gameObject.CompareTag("Dice"))
        {
            nonBattleUI.diceCount += 1;

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("BattlePoint"))
        {
            BattleCanvas.enabled = true;
            nonBattleCanvas.enabled = false;  
        }
    }
}
