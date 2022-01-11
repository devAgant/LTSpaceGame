using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogBox : MonoBehaviour
{   
    private string code;
    public Button button1;
    public Button button2;
    public Text npcText;

    public Text playerTxt1;
    public Text playerTxt2;
    private DialogScript current;

    private ArrayList options;
    // Start is called before the first frame update
    void Awake()
    {
        options = new ArrayList();
        current = new DialogScript("Big choice","optionA","OptionB","0");
        button1.onClick.AddListener(addA);
        button2.onClick.AddListener(addB);
        var arlist = new ArrayList();
        options.Add(new DialogScript("you chose option a","A","B","0A"));
        options.Add(new DialogScript("you chose option b","A","B","0B"));
        options.Add(new DialogScript("you chose option a and a again","A","B","0AA"));
        options.Add(new DialogScript("you chose option a then b","A","B","0AB"));
        options.Add(new DialogScript("you chose option b then a","A","B","0BA"));
        options.Add(new DialogScript("you chose option b and b again","A","B","0BB"));
        code = "0";
    }
    void addA(){
        code+="A";
    }
    void addB(){
        code+="B";
    }
    void changeBox(string changeTo)
    {
        foreach(DialogScript x in options){
            if (x.getCode().Equals(changeTo)){
                current = x;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
       if(code.Equals("0")){
           return;
       } 
       else if(code.Equals(current.getCode())){
           return;
       } 
       else{
           changeBox(code);
           playerTxt1.text = current.getPlayer1();
           playerTxt2.text = current.getPlayer2();
           npcText.text = current.getNpc();
           
       }
    }
}
