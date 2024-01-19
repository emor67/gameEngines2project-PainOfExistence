using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
class ChatBlock
{
    public string chat;
    public string option1Text;
    public string option2Text;


    public ChatBlock option1Block;
    public ChatBlock option2Block;
    public ChatBlock(string chat, string optionText1 = "", string optionText2 = "",
        ChatBlock optionBlock1 = null, ChatBlock optionBlock2 = null)
    {
        this.chat = chat;
        this.option1Text = optionText1;
        this.option2Text = optionText2;

        this.option1Block = optionBlock1;
        this.option2Block = optionBlock2;
    }
}

public class ChatScript : MonoBehaviour
{
    public TMP_Text chatText;
    public Button option1Button;
    public Button option2Button;

    public Collider2D dadCollider;
    public Collider2D motherCollider;
    public Collider2D grandmotherCollider;

    //dad chat count
    public int dadChatCount = 1;

    //button click count
    public int buttonClickCount = 0;

    ChatBlock currentBlock;

    //closer
    static ChatBlock block0 = new ChatBlock("","","");
    //dad3
    static ChatBlock block10 = new ChatBlock("Thank you, son. I'm crying now. Finally happened. You completed my pain. Whatever the reason, you were the result. I created you with the pain of my existence. I leave my entire existence and this pain to you.", "Daaaaaaad!!!!!", "Dad?", block0, block0);
    static ChatBlock block9 = new ChatBlock("Did you find any tears, my son?", "I found. What's going to happen, dad?", "Here you go dad. I found.", block10, block10);
    //grandmother 
    static ChatBlock block8 = new ChatBlock("Here you go, grandson, fresh fresh.", "How fresh, grandma. Anyway, let me go.", "Thank you, grandma.", block0, block0);
    static ChatBlock block7 = new ChatBlock("What do you need, grandson?", "Can you shed tears, grandma?", "I need tears, grandma, give me tears.", block8, block8);
    //dad2
    static ChatBlock block6 = new ChatBlock("Thank you, son. I'm bleeding now, but my pain hasn't subsided. I can't cry. Bring me tears?", "How can I find it? Anyway, I'll get it from my grandmother.", "Let me ask my grandmother.", block0, block0);
    static ChatBlock block5 = new ChatBlock("Did you find any blood, son?", "I found. What's going to happen, dad?", "Here you go dad. I found.", block6, block6);
    //mother
    static ChatBlock block4 = new ChatBlock("Here you go son, fresh fresh.", "How fresh, mom. Anyway, let me go.", "Thanks mom.", block0, block0);
    static ChatBlock block3 = new ChatBlock("What do I need, my son?", "Can you donate blood, mom?", "I need blood, mother, give blood.", block4, block4);
    //dad1
    static ChatBlock block2 = new ChatBlock("I can't handle it. Hurry up, son.", "Anyway, if my mother has it, I'll bring it.", "Let me ask my mother. Wait here.", block0, block0);
    static ChatBlock block1 = new ChatBlock("It hurts, son. I'm wounded but I'm not bleeding. Bring me blood.", "What do you say, dad? What blood?", "Ok dad. Hang on.", block2, block2);

    private void DisplayBlock(ChatBlock block)
    {
        chatText.text = block.chat;
        option1Button.GetComponentInChildren<TMP_Text>().text = block.option1Text;
        option2Button.GetComponentInChildren<TMP_Text>().text = block.option2Text;

        currentBlock = block;
    }

    private void Start()
    {
        dadCollider.enabled = true;
        motherCollider.enabled = false;
        grandmotherCollider.enabled = false;
    }
    public void DadChatController()
    {
        if (dadChatCount == 1)
        {
            DisplayBlock(block1);
        }
        if(dadChatCount == 2)
        {
            DisplayBlock(block5);
        }
        if (dadChatCount == 3)
        {
            DisplayBlock(block9);
        }
    }

    public void MotherChatController()
    {
        DisplayBlock(block3);
    }

    public void GrandmotherChatController()
    {
        DisplayBlock(block7);
    }

    public void Button1Clicked()
    {
        DisplayBlock(currentBlock.option1Block);
        buttonClickCount++;
    }
    public void Button2Clicked()
    {
        DisplayBlock(currentBlock.option2Block);
        buttonClickCount++;
    }
}
