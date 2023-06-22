using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] panels;    
    
    [SerializeField]
    private CarManager carManager;
    
    [SerializeField]
    private TextMeshProUGUI totalCostText;

    [SerializeField]
    private TextMeshProUGUI[] partsCostText;

    public int totalCost = 0;

    [SerializeField]
    private int panelNo = 0;

    
    void Start()
    {
        HideAll();
        MainPanel();
        
    }

    
    void Update()
    {
        totalCostText.SetText("£ " + totalCost.ToString());
        Stats();
    }

    public void Stats()
    {
        switch (panelNo)
        {
            case 0:
                //main menu
                break;
            case 1:
                partsCostText[panelNo].SetText("£ " + carManager.GetEngine.EngineCost.ToString());
                //eng
                break;
            case 2:
                partsCostText[panelNo].SetText("£ " + carManager.GetEngine.TurboCost.ToString());
                //turbo
                break;
            case 3:
                //gearbox
                break;
            case 4:
                //brakes
                break;
            case 5:
                //wheels
                break;
            case 6:
                //respray
                break;
        }
        
    }

    public void Stock()
    {
        switch (panelNo)
        {
            case 1:
                carManager.currentEngine.engineUpgrades = Engine.EngineUpgrades.Stock;
                break;
            case 2:
                carManager.currentEngine.turboUpgrades = Engine.TurboUpgrades.Stock;
                break;
        }
    }

    public void Street()
    {
        switch (panelNo)
        {
            case 1:
                carManager.currentEngine.engineUpgrades = Engine.EngineUpgrades.Street;
                break;
            case 2:
                carManager.currentEngine.turboUpgrades = Engine.TurboUpgrades.Street;
                break;
        }
    }

    public void Race()
    {
        switch (panelNo)
        {
            case 1:
                carManager.currentEngine.engineUpgrades = Engine.EngineUpgrades.Race;
                break;
            case 2:
                carManager.currentEngine.turboUpgrades = Engine.TurboUpgrades.Race;
                break;
        }
    }

    public void MainPanel()
    {
        panels[0].SetActive(true);
        panelNo = 0;
    }

    public void EnginePanel()
    {
        panels[1].SetActive(true);
        panelNo = 1;
    }

    public void TurboPanel()
    {
        panels[2].SetActive(true);
        panelNo = 2;
    }

    public void GearboxPanel()
    {
        if (!panels[3].active)
        {
            panels[3].SetActive(true);
        }
    }

    public void BrakesPanel()
    {
        if (!panels[4].active)
        {
            panels[4].SetActive(true);
        }
    }

    public void WheelsPanel()
    {
        if (!panels[5].active)
        {
            panels[5].SetActive(true);
        }
    }

    public void ResprayPanel()
    {
        if (!panels[6].active)
        {
            panels[6].SetActive(true);
        }
    }

    public void HideAll()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
    }
}
