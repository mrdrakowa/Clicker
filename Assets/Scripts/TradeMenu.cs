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
    
        
    // Start is called before the first frame update
    void Start()
    {
        money = Math.Round(Convert.ToDouble(PlayerPrefs.GetString("money")), 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
