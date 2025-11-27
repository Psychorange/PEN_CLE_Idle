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
    public float count;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goldText.text = goldAmount.ToString("00000");

        PText.text = power.ToString("00000");
        PCText.text = powerCost.ToString("00000");
        PLevelText.text = powerLevel.ToString("000");
    }

    public void ChangeGold()
    {
        goldAmount += power;
        goldText.text = goldAmount.ToString("00000");
    }

    public void ChangePower()
    {
        if (goldAmount >= powerCost)
        {
            goldAmount -= powerCost;
            powerLevel += 1;
            goldText.text = goldAmount.ToString("00000");
            PLevelText.text = powerLevel.ToString("000");

            power *= 2;
            powerCost *= 3;
            PText.text = power.ToString("00000");
            PCText.text = powerCost.ToString("00000");
        }
    }

    public void ChangeActions()
    {
        if (goldAmount >= actionCost)
        {
            CPSisActive = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(CPSisActive == true)
        {
            if(count <= CPScoldown)
            {
                count += Time.deltaTime;
            } else
            {
                count = 0;
                goldAmount += action;
            }
        }
    }

}

// arrondir Mathf.RoundToInt(powerPrice * 1.2f)