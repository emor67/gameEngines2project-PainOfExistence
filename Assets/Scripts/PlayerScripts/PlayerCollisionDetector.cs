using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionDetector : MonoBehaviour
{
    public ChatScript ChatScript;
    public PlayerMovement playerMovement;

    public Canvas BattleCanvas;
    public Canvas ChatCanvas;

    private void Start()
    {
        BattleCanvas.enabled = false;
        ChatCanvas.enabled = false;
    }

    private void Update()
    {
        if (BattleCanvas.enabled == true || ChatCanvas.enabled == true) 
        { 
            playerMovement.moveSpeed = 0;
        }
        else { playerMovement.moveSpeed = 5; }    

        if(ChatScript.buttonClickCount == 2)
        {
            ChatCanvas.enabled = false;

            ChatScript.buttonClickCount = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BattlePoint"))
        {
            BattleCanvas.enabled = true;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Dad"))
        {
            ChatScript.DadChatController();
            ChatCanvas.enabled = true;
            if (ChatScript.dadChatCount == 1)
            {
                ChatScript.motherCollider.enabled = true;
            }
            if (ChatScript.dadChatCount == 2)
            {
                ChatScript.grandmotherCollider.enabled = true;
            }
            ChatScript.dadCollider.enabled = false;
        }

        if (collision.gameObject.CompareTag("Mother"))
        {
            ChatScript.MotherChatController();
            ChatCanvas.enabled = true;
            ChatScript.dadChatCount = 2;
            ChatScript.dadCollider.enabled = true;
            ChatScript.motherCollider.enabled = false;
        }

        if (collision.gameObject.CompareTag("Grandmother"))
        {
            ChatScript.GrandmotherChatController();
            ChatCanvas.enabled = true;
            ChatScript.dadChatCount = 3;
            ChatScript.grandmotherCollider.enabled = false;
            ChatScript.dadCollider.enabled = true;
        }

        if (collision.gameObject.CompareTag("ExitHome"))
        {
            SceneManager.LoadScene("TownScene");
        }

        if (collision.gameObject.CompareTag("EnterHome"))
        {
            SceneManager.LoadScene("HomeScene");
        }
    }
}
