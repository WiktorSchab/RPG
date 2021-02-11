using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    [SerializeField] GameObject panel;
    [SerializeField] Slider hpBar;
    [SerializeField] Slider manaBar;
    void Start()
    {
        panel.SetActive(false);
        hpBar.value = hpBar.maxValue;
        hpBar.value = manaBar.maxValue * 0.7f;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)) panel.SetActive(true);
        if (Input.GetKeyUp(KeyCode.T)) panel.SetActive(false);
    }
}
