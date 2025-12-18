using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Power4 : MonoBehaviour
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

        goldManager.powerLevel += 2;
        goldManager.PLevelText.text = goldManager.powerLevel.ToString("000");
        goldManager.power = goldManager.power * 2f * 2f;
        goldManager.PText.text = goldManager.power.ToString("0000000");
        goldManager.powerCost = goldManager.powerCost * 3f * 3f;
        goldManager.PCText.text = goldManager.powerCost.ToString("0000000");

        powerIsActive = true;
        countActive.SetActive(true);
    }

    void Update()
    {
        if (powerIsActive == true)
        {
            if (countTime <= 12f)
            {
                countTime += Time.deltaTime;
                textCount.text = Mathf.RoundToInt(countTime).ToString("00 s");
            }
            else
            {
                countTime = 0;
                powerIsActive = false;
                countActive.SetActive(false);

                goldManager.powerLevel -= 2;
                goldManager.PLevelText.text = goldManager.powerLevel.ToString("000");
                goldManager.power = goldManager.power / 2f / 2f;
                goldManager.PText.text = goldManager.power.ToString("0000000");
                goldManager.powerCost = goldManager.powerCost / 3f / 3f;
                goldManager.PCText.text = goldManager.powerCost.ToString("0000000");
            }
        }
    }
}
