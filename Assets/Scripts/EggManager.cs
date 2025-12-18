using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EggManager : MonoBehaviour
{
    public GoldManager goldManager;
    public RandomEgg randomEgg;

    public float eggBought;
    public float eggCost;
    public TextMeshProUGUI ECText;
    public TextMeshProUGUI EBoughtText;

    public GameObject Egg1;
    public bool isActiveEgg1;
    public GameObject Egg2;
    public bool isActiveEgg2;

    public GameObject STOP;
    public bool STOPactive;

    public void AddEgg()
    {
        if (goldManager.goldAmount >= eggCost)
        {
            if (isActiveEgg1 == false)
            {
                Egg1.SetActive(true);
                isActiveEgg1 = true;
                randomEgg.DoRandomEgg1();
            }
            else
            {
                if (isActiveEgg2 == false && isActiveEgg1 == true)
                {
                    Egg2.SetActive(true);
                    isActiveEgg2 = true;
                    randomEgg.DoRandomEgg2();
                }
                else
                {
                    STOP.SetActive(true);
                    STOPactive = true;
                }
            }
            if(STOPactive == false)
            {
                goldManager.goldAmount -= eggCost;
                eggBought += 1;
                goldManager.goldText.text = goldManager.goldAmount.ToString("0000000");
                EBoughtText.text = eggBought.ToString("000");
            }               
        }
    }

    void Start()
    {
        ECText.text = eggCost.ToString("0000000");
        EBoughtText.text = eggBought.ToString("000");
    }

}
