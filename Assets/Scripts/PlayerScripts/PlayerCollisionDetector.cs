using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetector : MonoBehaviour
{
    public NonBattleUI battleUI;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dice"))
        {
            battleUI.diceCount += 1;

            Destroy(collision.gameObject);
        }
    }
}
