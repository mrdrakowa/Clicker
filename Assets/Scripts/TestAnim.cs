using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnim : MonoBehaviour
{

    public Animator contentPanel;

    public void ToggleMenu()
    {
        bool IsHidden = contentPanel.GetBool("IsHidden");
        contentPanel.SetBool("IsHidden", !IsHidden);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
