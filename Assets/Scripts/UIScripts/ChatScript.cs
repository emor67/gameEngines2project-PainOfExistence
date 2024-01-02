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

    ChatBlock currentBlock;
    
    static ChatBlock block3 = new ChatBlock("beðenmezsen bb caným","gidiyorum","gitmiyorum");
    static ChatBlock block2 = new ChatBlock("5 lira", "tamam al", "çok dedin");
    static ChatBlock block1 = new ChatBlock("Gel kardeþim, gel", "tamam geliyorum", "gelmem", block2, block3);

    // Start is called before the first frame update
    void Start()
    {
       ///will be moved
       DisplayBlock(block1);
    }

    private void DisplayBlock(ChatBlock block)
    {
        chatText.text = block.chat;
        option1Button.GetComponentInChildren<TMP_Text>().text = block.option1Text;
        option2Button.GetComponentInChildren<TMP_Text>().text = block.option2Text;

        currentBlock = block;
    }
    
    public void Button1Clicked()
    {
        DisplayBlock(currentBlock.option1Block);
    }
    public void Button2Clicked()
    {
        DisplayBlock(currentBlock.option2Block);
    }
}
