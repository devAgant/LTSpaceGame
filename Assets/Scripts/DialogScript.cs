using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DialogScript
{
    private string npcDialog;
    private string playerChoice1;
    private string playerChoice2;

    private string code;
    //("insert npc dialogue", "insert player opt1", "insert player option 2", "insert dialog code")
    public DialogScript(string npc, string player1, string player2, string code1){
        npcDialog = npc;
        playerChoice1 = player1;
        playerChoice2 = player2;
        code = code1;
    }
    public string getNpc(){
        return npcDialog;
    }
    public string getPlayer1(){
        return playerChoice1;
    }
    public string getPlayer2(){
        return playerChoice2;
    }
    public string getCode(){
        return code;
    }
}
