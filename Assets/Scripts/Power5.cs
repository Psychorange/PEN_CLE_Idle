using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Power5 : MonoBehaviour
{
    public RandomEgg randomEggManager;
    public GoldManager goldManager;

    public bool powerIsActive;
    public float countTime;

    public GameObject countActive;
    public TextMeshProUGUI textCount;

    public void OnClic()
    {
        randomEggManager.PowerBGPosition.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power1Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power2Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power3Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power4Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power5Position.position = new Vector3(10000, 10000, 10000);

        goldManager.actionLevel += 2;
        goldManager.ALevelText.text = goldManager.actionLevel.ToString("000");
        goldManager.action = Mathf.RoundToInt(goldManager.action * 2.6f * 2.6f);
        goldManager.AText.text = goldManager.action.ToString("0000000");
        goldManager.actionCost = Mathf.RoundToInt(goldManager.actionCost * 2.6f * 2.6f);
        goldManager.ACText.text = goldManager.actionCost.ToString("0000000");

        powerIsActive = true;
        countActive.SetActive(true);
    }

    void Update()
    {
        if (powerIsActive == true)
        {
            if (countTime <= 24f)
            {
                countTime += Time.deltaTime;
                textCount.text = Mathf.RoundToInt(countTime).ToString("00 s");
            }
            else
            {
                countTime = 0;
                powerIsActive = false;
                countActive.SetActive(false);

                goldManager.actionLevel -= 2;
                goldManager.ALevelText.text = goldManager.actionLevel.ToString("000");
                goldManager.action = Mathf.RoundToInt(goldManager.action / 2.6f / 2.6f);
                goldManager.AText.text = goldManager.action.ToString("0000000");
                goldManager.actionCost = Mathf.RoundToInt(goldManager.actionCost / 2.6f / 2.6f);
                goldManager.ACText.text = goldManager.actionCost.ToString("0000000");
            }
        }
    }
}
