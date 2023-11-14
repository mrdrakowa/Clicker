using System.Collections;
using System;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TradeMenu : MonoBehaviour
{
    [SerializeField] double money;
    [SerializeField] double plastic;
    [SerializeField] double glass;
    [SerializeField] double can;

    public TextMeshProUGUI text_plastic;
    public TextMeshProUGUI text_glass;
    public TextMeshProUGUI text_can;
    public TextMeshProUGUI text_money;

    // Start is called before the first frame update
    void Start()
    {
        money = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("money")), 2);
        plastic = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("plastic")), 2);
        glass = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("glass")), 2);
        can = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("can")), 2);

        text_money.text = money.ToString();
        text_plastic.text = plastic.ToString();
        text_glass.text = glass.ToString();
        text_can.text = can.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void PlasticButton()
    {
        money += plastic * 0.25;
        plastic = 0;
        PlayerPrefs.SetString("plastic", plastic.ToString());
        PlayerPrefs.SetString("money", money.ToString());
        text_money.text = money.ToString();
        text_plastic.text = plastic.ToString();
    }
    public void GlassButton()
    {
        money += glass * 0.5;
        glass = 0;
        PlayerPrefs.SetString("glass", glass.ToString());
        PlayerPrefs.SetString("money", money.ToString());
        text_glass.text = glass.ToString();
        text_money.text = money.ToString();
    }
    public void CanButton()
    {
        money += can * 1;
        can = 0;
        PlayerPrefs.SetString("can", glass.ToString());
        PlayerPrefs.SetString("money", money.ToString());
        text_can.text = can.ToString();
        text_money.text = money.ToString();
    }
    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
}
