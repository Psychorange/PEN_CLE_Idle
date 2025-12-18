using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldManager : MonoBehaviour
{
    public float goldAmount;
    public TextMeshProUGUI goldText;

    public float power;
    public float powerLevel;
    public float powerCost;
    public TextMeshProUGUI PText;
    public TextMeshProUGUI PCText;
    public TextMeshProUGUI PLevelText;

    public float action;
    public float actionLevel;
    public float actionCost;
    public TextMeshProUGUI AText;
    public TextMeshProUGUI ACText;
    public TextMeshProUGUI ALevelText;
    public bool CPSisActive;
    public float CPScoldown;
    public float countTime;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goldText.text = goldAmount.ToString("0000000");

        PText.text = power.ToString("0000000");
        PCText.text = powerCost.ToString("0000000");
        PLevelText.text = powerLevel.ToString("000");

        AText.text = action.ToString("0000000");
        ACText.text = actionCost.ToString("0000000");
        ALevelText.text = actionLevel.ToString("000");
    }

    public void ChangeGold()
    {
        goldAmount += power;
        goldText.text = goldAmount.ToString("0000000");
    }

    public void ChangePower()
    {
        if (goldAmount >= powerCost)
        {
            goldAmount -= powerCost;
            powerLevel += 1;
            goldText.text = goldAmount.ToString("0000000");
            PLevelText.text = powerLevel.ToString("000");

            power *= 2;
            powerCost *= 3f;
            PText.text = power.ToString("0000000");
            PCText.text = powerCost.ToString("0000000");
        }
    }

    public void ChangeActions()
    {
        if (goldAmount >= actionCost)
        {
            goldAmount -= actionCost;
            CPSisActive = true;
            actionLevel += 1;
            goldText.text = goldAmount.ToString("0000000");
            ALevelText.text = actionLevel.ToString("000");

            if (action != 0f)
            {
                action = Mathf.RoundToInt(action * 2.6f);
            } else
            {
                action = 2f;
            }
            actionCost = Mathf.RoundToInt(actionCost * 2.6f);
            AText.text = action.ToString("0000000");
            ACText.text = actionCost.ToString("0000000");

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(CPSisActive == true)
        {
            if(countTime <= CPScoldown)
            {
                countTime += Time.deltaTime;
            } else
            {
                countTime = 0;
                goldAmount += action;
                goldText.text = goldAmount.ToString("0000000");
            }
        }
    }

}

// arrondir Mathf.RoundToInt(powerPrice * 1.2f)