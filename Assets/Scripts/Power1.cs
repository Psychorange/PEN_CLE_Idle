using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Power1 : MonoBehaviour
{
    public RandomEgg randomEggManager;
    public GoldManager goldManager;

    public int GoldPower1;

    public TextMeshProUGUI P1Text;

    public void OnClic()
    {
        randomEggManager.PowerBGPosition.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power1Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power2Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power3Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power4Position.position = new Vector3(10000, 10000, 10000);
        randomEggManager.Power5Position.position = new Vector3(10000, 10000, 10000);

        goldManager.goldAmount += GoldPower1;
        goldManager.goldText.text = goldManager.goldAmount.ToString("0000000");
    }
}
