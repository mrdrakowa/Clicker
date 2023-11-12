using System.Collections;
using System;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MainMenu : MonoBehaviour
{
    [SerializeField] double money;
    [SerializeField] double k; // the coefficient of increasing money
    [SerializeField] double CritChance;
    [SerializeField] int rand;
    [SerializeField] int rand2;
    [SerializeField] double plastic;
    [SerializeField] double glass;
    [SerializeField] double can;
   
    public TextMeshProUGUI text_plastic;
    public TextMeshProUGUI text_glass;
    public TextMeshProUGUI text_can;

    public Animator contentPanel;

    public void ToggleMenu()
    {
        bool isHidden = contentPanel.GetBool("isHidden");
        contentPanel.SetBool("isHidden", !isHidden);
    }   

    public void ZerO()
    {
        PlayerPrefs.SetString("money", 0.ToString());
        PlayerPrefs.SetString("k", 0.ToString());
        PlayerPrefs.SetString("costBottlesPerClick", 10.ToString());
        PlayerPrefs.SetString("LVLCrit", 0.ToString());
        PlayerPrefs.SetString("costCrit", 100.ToString());
        PlayerPrefs.SetString("CritChance", 0.00.ToString());
     
        k = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("k")),2);
        money = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("money")),2);
        CritChance = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("CritChance")),2);
    }
    
    public void ButtonClick()
    {

        System.Random rnd = new System.Random(Convert.ToInt32(DateTime.Now.Millisecond));
        System.Random rnd2 = new System.Random(Convert.ToInt32(DateTime.Now.Millisecond));
        rand = rnd.Next(1, 100);
        rand2 = rnd2.Next(1, 100);
        if(rand2 >= 50 && rand2 < 75)
        {
            plastic++;
            text_plastic.text = plastic.ToString();
        }else if(rand2 >= 75 && rand2 < 90)
        {
            glass++;
            text_glass.text = glass.ToString();
        }
        else if(rand2 >= 90 && rand2 <= 100)
        {
            can++;
            text_can.text = can.ToString();
        }
        
        
        /*CritChance = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("CritChance")), 2);
        if (rand <= Math.Round(CritChance*100))
        {
            money = Math.Round(money + (0.1 + k)*2, 2);
            text.text = money.ToString()+ " CRIT!!!";
        }
        else
        {
            money = Math.Round(money + 0.1 + k, 2);
            text.text = money.ToString();
        }*/
        
        PlayerPrefs.SetString("glass", glass.ToString());
        PlayerPrefs.SetString("plastic", plastic.ToString());
        PlayerPrefs.SetString("can", can.ToString());
    }

    public void ToShop()
    {
        SceneManager.LoadScene(1);
    }
    public void ToTrade()
    {
        SceneManager.LoadScene(1);
    }


    // Start is called before the first frame update
    void Start()
    {
        money = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("money")), 2);
        plastic = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("plastic")));
        glass = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("glass")));
        can = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("can")));
        k = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("k")),2);
        CritChance = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("CritChance")), 2);
        text_plastic.text = plastic.ToString();
        text_glass.text = glass.ToString();
        text_can.text = can.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
