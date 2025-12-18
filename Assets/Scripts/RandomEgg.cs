using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class RandomEgg : MonoBehaviour
{

    public EggManager eggManager;
    public Power1 powerGold;
    public GoldManager goldManager;

    public Transform Power1Position;
    public Transform Power2Position;
    public Transform Power3Position;
    public Transform Power4Position;
    public Transform Power5Position;

    public Transform PowerBGPosition;

    public Transform MiddlePosition;
    public Transform RightPosition;
    public Transform LeftPosition;

    public int maxEggClic1;
    public int maxEggClic2;
    public int eggClic1;
    public int eggClic2;

    public List<int> eggSeed1;
    public List<int> eggSeed2;

    public void DoRandomEgg1()
    {
        maxEggClic1 = Random.Range(100, 200);
        eggSeed1 = new List<int>
        {
            Random.Range(1, 6),
            Random.Range(1, 6)
        };
        while (eggSeed1[1] == eggSeed1[0])
        {
            eggSeed1[1] = Random.Range(1, 6);
        }
    }


    public void DoRandomEgg2()
    {
        maxEggClic2 = Random.Range(100, 200);
        eggSeed2 = new List<int>
        {
            Random.Range(1, 6),
            Random.Range(1, 6)
        };
        while (eggSeed2[1] == eggSeed2[0])
        {
            eggSeed2[1] = Random.Range(1, 6);
        }
    }


    public void Egg1Clic()
    {
        if(eggClic1 >= maxEggClic1)
        {
            eggClic1 = 0;
            eggManager.isActiveEgg1 = false;
            eggManager.Egg1.SetActive(false);
            PowerBGPosition.position = MiddlePosition.position;

            if (eggSeed1[0] == 1)
            {
                Power1Position.position = LeftPosition.position;
                powerGold.GoldPower1 = Mathf.RoundToInt((goldManager.actionLevel + goldManager.powerLevel) * (goldManager.actionCost / 10 + goldManager.powerCost / 10));
                powerGold.P1Text.text = powerGold.GoldPower1.ToString("+00");
            } else
            {
                if (eggSeed1[0] == 2)
                {
                    Power2Position.position = LeftPosition.position;
                } else
                {
                    if (eggSeed1[0] == 3)
                    {
                        Power3Position.position = LeftPosition.position;
                    } else
                    {
                        if (eggSeed1[0] == 4)
                        {
                            Power4Position.position = LeftPosition.position;
                        } else
                        {
                            if (eggSeed1[0] == 5)
                            {
                                Power5Position.position = LeftPosition.position;
                            }
                        }
                    }
                }
            }


            if (eggSeed1[1] == 1)
            {
                Power1Position.position = RightPosition.position;
                powerGold.GoldPower1 = Mathf.RoundToInt((goldManager.actionLevel + goldManager.powerLevel) * (goldManager.actionCost / 10 + goldManager.powerCost / 10));
                powerGold.P1Text.text = powerGold.GoldPower1.ToString("+00");
            } else
            {
                if (eggSeed1[1] == 2)
                {
                    Power2Position.position = RightPosition.position;
                } else
                {
                    if (eggSeed1[1] == 3)
                    {
                        Power3Position.position = RightPosition.position;
                    } else
                    {
                        if (eggSeed1[1] == 4)
                        {
                            Power4Position.position = RightPosition.position;
                        } else
                        {
                            if (eggSeed1[1] == 5)
                            {
                                Power5Position.position = RightPosition.position;
                            }
                        }
                    }
                }
            }


        } else
        {
            eggClic1 += 1;
        }
        
    }


    public void Egg2Clic()
    {
        if (eggClic2 >= maxEggClic2)
        {
            eggClic2 = 0;
            eggManager.isActiveEgg2 = false;
            eggManager.Egg2.SetActive(false);
            PowerBGPosition.position = MiddlePosition.position;

            if (eggSeed2[0] == 1)
            {
                Power1Position.position = LeftPosition.position;
                powerGold.GoldPower1 = Mathf.RoundToInt((goldManager.actionLevel + goldManager.powerLevel) * (goldManager.actionCost / 10 + goldManager.powerCost / 10));
                powerGold.P1Text.text = powerGold.GoldPower1.ToString("+00");
            }
            else
            {
                if (eggSeed2[0] == 2)
                {
                    Power2Position.position = LeftPosition.position;
                }
                else
                {
                    if (eggSeed2[0] == 3)
                    {
                        Power3Position.position = LeftPosition.position;
                    }
                    else
                    {
                        if (eggSeed2[0] == 4)
                        {
                            Power4Position.position = LeftPosition.position;
                        }
                        else
                        {
                            if (eggSeed2[0] == 5)
                            {
                                Power5Position.position = LeftPosition.position;
                            }
                        }
                    }
                }
            }


            if (eggSeed2[1] == 1)
            {
                Power1Position.position = RightPosition.position;
                powerGold.GoldPower1 = Mathf.RoundToInt((goldManager.actionLevel + goldManager.powerLevel) * (goldManager.actionCost / 10 + goldManager.powerCost / 10));
                powerGold.P1Text.text = powerGold.GoldPower1.ToString("+00");
            }
            else
            {
                if (eggSeed2[1] == 2)
                {
                    Power2Position.position = RightPosition.position;
                }
                else
                {
                    if (eggSeed2[1] == 3)
                    {
                        Power3Position.position = RightPosition.position;
                    }
                    else
                    {
                        if (eggSeed2[1] == 4)
                        {
                            Power4Position.position = RightPosition.position;
                        }
                        else
                        {
                            if (eggSeed2[1] == 5)
                            {
                                Power5Position.position = RightPosition.position;
                            }
                        }
                    }
                }
            }
        }


        else
        {
            eggClic2 += 1;
        }
    }
}
