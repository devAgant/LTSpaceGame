using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BankHandler : MonoBehaviour
{

    [SerializeField] private InputField inputText;
    public static int balance = 200;
    private static bool exitHasBeenCalled;

    void Start()
    {
        
    }
    void Update()
    {
        if (!GameObject.Find("WalletInfo").GetComponent<Text>().text.Equals("Wallet: " + ScoreInterface.score))
        {
            GameObject.Find("WalletInfo").GetComponent<Text>().text = "Wallet: " + ScoreInterface.score;
        }
        if (!GameObject.Find("BalanceInfo").GetComponent<Text>().text.Equals("Balance: " + balance))
        {
            GameObject.Find("BalanceInfo").GetComponent<Text>().text = "Balance: " + balance;
        }
        if (exitHasBeenCalled == true) {
            exitHasBeenCalled = false;
        }
    }
    public void Switch()
    {
        if (gameObject.transform.parent.name.Equals("YourItems"))
        {
            gameObject.transform.SetParent(GameObject.Find("BankerItems").transform);
        }
        else if(gameObject.transform.parent.name.Equals("BankerItems"))
        {
            gameObject.transform.SetParent(GameObject.Find("YourItems").transform);
        }
    }

    public void Deposit()
    {
        string amount = inputText.text;
        int amt = 0;
        if (!int.TryParse(amount, out amt))
        {
            GameObject.Find("Feedback").GetComponent<Text>().text = "Must be a valid Integer (not too large)";
            return;
        }
        if (amt < 1)
        {
            GameObject.Find("Feedback").GetComponent<Text>().text = "Must be greater than 0";
            return;
        }
        if (amt > ScoreInterface.score)
        {
            GameObject.Find("Feedback").GetComponent<Text>().text = "You don't have that much in your wallet";
            return;
        }
        ScoreInterface.score -= amt;
        balance += amt;
        GameObject.Find("Feedback").GetComponent<Text>().text = "Deposited " + amt;
    }
    
    public void Withdraw()
    {
        string amount = inputText.text;
        int amt = 0;
        if (!int.TryParse(amount, out amt))
        {
            GameObject.Find("Feedback").GetComponent<Text>().text = "Must be an Integer (not too large)";
            return;
        }
        if (amt < 1)
        {
            GameObject.Find("Feedback").GetComponent<Text>().text = "Must be greater than 0";
            return;
        }

        if (amt > balance)
        {
            GameObject.Find("Feedback").GetComponent<Text>().text = "You don't have that much in your bank balance";
            return;
        }

        ScoreInterface.score += amt;
        balance -= amt;
        GameObject.Find("Feedback").GetComponent<Text>().text = "Withdrew " + amt;
    }
     public static void ExitHasBeenCalled() {
        exitHasBeenCalled = true;
    }
}
