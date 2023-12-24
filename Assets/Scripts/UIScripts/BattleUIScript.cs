using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUIScript : MonoBehaviour
{
    //0 is neutral
    //1 is win
    //2 is lose
    public int winCondition = 0;

    void Start()
    {
        
    }


    void Update()
    {
        BattleSequence();
    }

    public void BattleSequence()
    {
        if (winCondition == 1)
        {
            Win();

        }else if (winCondition == 2)
        {
            Lose();
        }
    }

    private void Win()
    {

    }

    private void Lose()
    {

    }
}
