using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NonBattleUI : MonoBehaviour
{
    public TMP_Text diceCountText;
    public int diceCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        diceCountText.text = "Dice Count: " + diceCount;
    }
}
