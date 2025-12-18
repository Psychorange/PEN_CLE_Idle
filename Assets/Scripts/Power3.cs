using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Power3 : MonoBehaviour
{
    public RandomEgg randomEggManager;
    public GoldManager goldManager;

    public void OnClic()
    {
        randomEggManager.PowerBGPosition.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power1Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power2Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power3Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power4Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power5Position.position = new Vector3(10000, 10000, 10000);

        goldManager.powerLevel += 1;
        goldManager.PLevelText.text = goldManager.powerLevel.ToString("000");
        goldManager.power = goldManager.power * 2f;
        goldManager.PText.text = goldManager.power.ToString("0000000");
        goldManager.powerCost = goldManager.powerCost * 3f;
        goldManager.PCText.text = goldManager.powerCost.ToString("0000000");

        goldManager.actionLevel -= 2;
        goldManager.ALevelText.text = goldManager.actionLevel.ToString("000");
        goldManager.action = Mathf.RoundToInt(goldManager.action / 2.6f / 2.6f);
        goldManager.AText.text = goldManager.action.ToString("0000000");
        goldManager.actionCost = Mathf.RoundToInt(goldManager.actionCost / 2.6f / 2.6f);
        goldManager.ACText.text = goldManager.actionCost.ToString("0000000");
    }
}