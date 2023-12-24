using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleUIScript : MonoBehaviour
{
    //0 is neutral
    //1 is win
    //2 is lose
    public int winCondition = 0;

    public Canvas BattleCanvas;

    public int dice1;
    public int dice2;
    public int dice3;

    public int enemy1;
    public int enemy2;

    public TMP_Text button1Text;
    public TMP_Text button2Text;
    public TMP_Text button3Text;

    public TMP_Text enemy1Text;
    public TMP_Text enemy2Text;

    public int damage = 0;

    public int playerHealth;
    public int enemyHealth;

    public TMP_Text playerHealthText;
    public TMP_Text enemyHealthText;

    ///////////

    public Button button1;
    public Button button2;
    public Button button3;

    public Button enemyB1;
    public Button enemyB2;

    void Start()
    {
        dice1 = Random.Range(1, 7);
        dice2 = Random.Range(1, 7);
        dice3 = Random.Range(1, 7);

        button1Text.text = dice1.ToString();
        button2Text.text = dice2.ToString();
        button3Text.text = dice3.ToString();

        enemy1 = Random.Range(1, 7);
        enemy2 = Random.Range(1, 7);

        enemy1Text.text = enemy1.ToString();
        enemy2Text.text = enemy2.ToString();
    }


    void Update()
    {
        //BattleSequence();

        playerHealthText.text = playerHealth.ToString();
        enemyHealthText.text = enemyHealth.ToString();
    }
   
    
    /*public void BattleSequence()
    {
        if (winCondition == 1)
        {
            
        }else if (winCondition == 2)
        {
            
        }else if(winCondition == 0)
        {

        }
    }*/

    #region Battle Buttons
    public void Button1()
    {
        damage = dice1;
        dice1 = 0;
        button1.interactable = false;
    }
    public void Button2()
    {
        damage = dice2;
        dice2 = 0;
        button2.interactable = false;
    }
    public void Button3()
    {
        damage = dice3;
        dice3 = 0;
        button3.interactable = false;
    }
    public void HealButton()
    {
        playerHealth += damage;
    }
    public void EndBattleButton()
    {
        playerHealth -= enemy1 + enemy2;
        enemyHealth -= dice1 + dice2 + dice3;

        if (enemyHealth <= 0)
        {
            Debug.Log("Win");
        }else if (playerHealth <= 0)
        {
            Debug.Log("Lose");
        }else { /*close battle continue*/}

        BattleCanvas.enabled = false;
    }

    public void Enemy1()
    {
        enemy1 -= damage;
        damage = 0;
        if(enemy1 < 0)
        {
            enemyHealth += enemy1;
            enemy1 = 0;
        }
        if (enemy1 <= 0)
        {
            enemyB1.interactable = false;
        }
    }
    public void Enemy2()
    {
        enemy2 -= damage;
        damage = 0;
        if (enemy2 < 0)
        {
            enemyHealth += enemy2;
            enemy2 = 0;
        }
        if (enemy2 <= 0) 
        { 
            enemyB2.interactable = false; 
        }
    }
    #endregion 
}
