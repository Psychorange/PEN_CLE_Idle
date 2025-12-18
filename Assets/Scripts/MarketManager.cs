using TMPro;
using UnityEngine;

public class MarketManager : MonoBehaviour
{
    public GoldManager goldManager;

    public TextMeshProUGUI investmentText;
    public int investment;
    public int betterInvestment;

    public int actionValue;
    public TextMeshProUGUI AVText;

    public float everyOneSecTimer;
    public int randomNumber;
    public int actionValueInterest;
    public int defaultActionValueInterest;
    public GameObject redArrow;
    public GameObject greenArrow;
    public bool investmentIsActive;

    public void Start()
    {
        investmentText.text = investment.ToString("00000");
        AVText.text = actionValue.ToString("0000000");
        actionValueInterest = defaultActionValueInterest;
    }

    public void LeftArrow()
    {
        if (investmentIsActive == false)
        {
            investment -= betterInvestment;
            investmentText.text = investment.ToString("00000");
        }
    }

    public void RightArrow()
    {
        if (investmentIsActive == false)
        {
            investment += betterInvestment;
            investmentText.text = investment.ToString("00000");
        }
    }

    public void IncreaseInvestment()
    {
        betterInvestment = investment;
    }

    public void ResetInvestment()
    {
        betterInvestment = 10;
        investment = 0;
        investmentText.text = investment.ToString("00000");
    }

    public void Invest()
    {
        if (investmentIsActive == false)
        {
            if (investment <= goldManager.goldAmount)
            {
                goldManager.goldAmount -= investment;
                actionValue = investment;
                ResetInvestment();
                goldManager.goldText.text = goldManager.goldAmount.ToString("0000000");
                investmentText.text = investment.ToString("00000");
                AVText.text = actionValue.ToString("0000000");
                investmentIsActive = true;
            }
        }
    }

    public void SellAction()
    {
        if (investmentIsActive == true)
        {
            goldManager.goldAmount += actionValue;
            actionValue = 0;
            actionValueInterest = defaultActionValueInterest;
            goldManager.goldText.text = goldManager.goldAmount.ToString("0000000");
            AVText.text = actionValue.ToString("0000000");
            redArrow.SetActive(false);
            greenArrow.SetActive(false);
            investmentIsActive = false;
        }
    }

    public void Update()
    {
        if (investment < 0)
        {
            investment = 0;
            investmentText.text = investment.ToString("00000");
        }

        if (actionValue != 0)
        {
            if (everyOneSecTimer >= 1)
            {
                everyOneSecTimer = 0;
                randomNumber = Random.Range(1, 101);

                if (randomNumber >= actionValueInterest)
                {
                    actionValue += randomNumber * actionValue / 100;
                    actionValueInterest -= 1;
                    redArrow.SetActive(false);
                    greenArrow.SetActive(true);
                }
                else
                {
                    actionValue -= randomNumber * actionValue / 100;
                    actionValueInterest += 2;
                    redArrow.SetActive(true);
                    greenArrow.SetActive(false);
                }
                if (actionValue == 1)
                {
                    actionValue = 0;
                }
                if (actionValue > investment * 300)
                {
                    actionValueInterest += 2;
                }
                AVText.text = actionValue.ToString("0000000");

            }
            else
            {
                everyOneSecTimer += Time.deltaTime;
            }
        }
        else
        {
            redArrow.SetActive(false);
            investmentIsActive = false;
            actionValueInterest = defaultActionValueInterest;
        }
    }
}

