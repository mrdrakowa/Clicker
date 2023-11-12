using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ShopMeny : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] double money;
    [SerializeField] double k;
    [SerializeField] double LVLCrit;
    [SerializeField] double costBottlesPerClick;
    [SerializeField] double costCrit;
    [SerializeField] double CritChance;
    public TextMeshProUGUI textBPC;
    public TextMeshProUGUI textBottles;
    public TextMeshProUGUI textLVLBPC;
    public TextMeshProUGUI textCrit;
    public TextMeshProUGUI textCritChance;
    public TextMeshProUGUI textLVLCrit;

    public void ButtonBack()
    {
        SceneManager.LoadScene(0);
    }
    public void ButtonBottlesPerClick()
    {
        if (money >= costBottlesPerClick)
        {
            k = k + 0.1;
            PlayerPrefs.SetString("k", k.ToString());

            money = Math.Round(money - costBottlesPerClick,2);
            costBottlesPerClick = Math.Round(costBottlesPerClick + costBottlesPerClick * Math.Pow(1.07,k), 2);
            PlayerPrefs.SetString("money", money.ToString());
            PlayerPrefs.SetString("costBottlesPerClick", costBottlesPerClick.ToString());
        }
        textBPC.text = costBottlesPerClick.ToString();
        textBottles.text = money.ToString();
        textLVLBPC.text = k.ToString();
    }
    public void ButtonCrit()
    {
        if(money >= costCrit)
        {
            money = Math.Round(money - costCrit, 2);
            CritChance = Math.Round(CritChance + 0.01,2);
            LVLCrit = Math.Round(LVLCrit + 1,2);
            costCrit = Math.Round(costCrit + costCrit * Math.Pow(1.07, LVLCrit), 2);
            PlayerPrefs.SetString("costCrit", costCrit.ToString());
            PlayerPrefs.SetString("CritChance", CritChance.ToString());
            PlayerPrefs.SetString("LVLCrit", LVLCrit.ToString());
            PlayerPrefs.SetString("money", money.ToString());
        }
        textLVLCrit.text = LVLCrit.ToString();
        textBottles.text = money.ToString();
        textCrit.text = costCrit.ToString();
        textCritChance.text = CritChance.ToString();
    }

    void Start()
    {
        money = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("money")),2);
        k = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("k")),2);
        costBottlesPerClick = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("costBottlesPerClick")),2);
        CritChance = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("CritChance")),2);
        costCrit = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("costCrit")),2);
        LVLCrit = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("LVLCrit")),2);
        
        
        
        
        textBPC.text = costBottlesPerClick.ToString();
        textBottles.text = money.ToString();
        textLVLBPC.text = k.ToString();
        textLVLCrit.text = LVLCrit.ToString();
        textBottles.text = money.ToString();
        textCrit.text = costCrit.ToString();  
        textCritChance.text = CritChance.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
