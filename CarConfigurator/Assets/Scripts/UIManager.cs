using System.Reflection;
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
    private Engine tempEngine = new Engine();

    
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
                partsCostText[panelNo].SetText("£ " + carManager.GetEngine.GearboxCost.ToString());
                //gearbox
                break;
            case 4:
                partsCostText[panelNo].SetText("£ " + carManager.GetEngine.BrakesCost.ToString());
                //brakes
                break;
            case 5:
                
                //respray
                break;
        }
        
    }

    public void Confirm()
    {
        totalCost = carManager.GetEngine.EngineCost + carManager.GetEngine.TurboCost +
            carManager.GetEngine.GearboxCost + carManager.GetEngine.BrakesCost;
    }

    public void Back()
    {
        switch(panelNo)
        {
            case 0:
                break;
            case 1:
                carManager.currentEngine.engineUpgrades = tempEngine.engineUpgrades;
                break;
            case 2:
                carManager.currentEngine.turboUpgrades = tempEngine.turboUpgrades;
                break;
            case 3:
                carManager.currentEngine.gearboxUpgrades = tempEngine.gearboxUpgrades;
                break;
            case 4:
                carManager.currentEngine.brakesUpgrades = tempEngine.brakesUpgrades;
                break;
            case 5:
                //respray stuff
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
            case 3:
                carManager.currentEngine.gearboxUpgrades = Engine.GearboxUpgrades.Stock;
                break;
            case 4:
                carManager.currentEngine.brakesUpgrades = Engine.BrakesUpgrades.Stock;
                break;
            case 5:
                carManager.currentBodywork.paintjob = Bodywork.Paintjob.Stock;
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
            case 3:
                carManager.currentEngine.gearboxUpgrades = Engine.GearboxUpgrades.Street;
                break;
            case 4:
                carManager.currentEngine.brakesUpgrades = Engine.BrakesUpgrades.Street;
                break;
            case 5:
                carManager.currentBodywork.paintjob = Bodywork.Paintjob.Red;
                break;
        }
    }

    public void Sport()
    {
        switch (panelNo)
        {
            case 1:
                carManager.currentEngine.engineUpgrades = Engine.EngineUpgrades.Sport;
                break;
            case 2:
                carManager.currentEngine.turboUpgrades = Engine.TurboUpgrades.Sport;
                break;
            case 3:
                carManager.currentEngine.gearboxUpgrades = Engine.GearboxUpgrades.Sport;
                break;
            case 4:
                carManager.currentEngine.brakesUpgrades = Engine.BrakesUpgrades.Sport;
                break;
            case 5:
                carManager.currentBodywork.paintjob = Bodywork.Paintjob.Blue;
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
            case 3:
                carManager.currentEngine.gearboxUpgrades = Engine.GearboxUpgrades.Race;
                break;
            case 4:
                carManager.currentEngine.brakesUpgrades = Engine.BrakesUpgrades.Race;
                break;
            case 5:
                carManager.currentBodywork.paintjob = Bodywork.Paintjob.Orange;
                break;
        }
    }

    public void MainPanel()
    {
        panels[0].SetActive(true);
        panelNo = 0;
        ClearLog();
        Debug.Log("Current Engine: " + carManager.currentEngine.engineUpgrades.ToString());
        Debug.Log("Current Turbo: " + carManager.currentEngine.turboUpgrades.ToString());
        Debug.Log("Current Gearbox: " + carManager.currentEngine.gearboxUpgrades.ToString());
        Debug.Log("Current Brakes: " + carManager.currentEngine.brakesUpgrades.ToString());
    }

    public void EnginePanel()
    {
        panels[1].SetActive(true);
        panelNo = 1;
        switch((int)carManager.currentEngine.engineUpgrades)
        {
            case 0:
                tempEngine.engineUpgrades = Engine.EngineUpgrades.Stock;
                break;
            case 1:
                tempEngine.engineUpgrades = Engine.EngineUpgrades.Street;
                break;
            case 2:
                tempEngine.engineUpgrades = Engine.EngineUpgrades.Sport;
                break;
            case 3:
                tempEngine.engineUpgrades = Engine.EngineUpgrades.Race;
                break;
        }
    }

    public void TurboPanel()
    {
        panels[2].SetActive(true);
        panelNo = 2;
        switch ((int)carManager.currentEngine.turboUpgrades)
        {
            case 0:
                tempEngine.turboUpgrades = Engine.TurboUpgrades.Stock;
                break;
            case 1:
                tempEngine.turboUpgrades = Engine.TurboUpgrades.Street;
                break;
            case 2:
                tempEngine.turboUpgrades = Engine.TurboUpgrades.Sport;
                break;
            case 3:
                tempEngine.turboUpgrades = Engine.TurboUpgrades.Race;
                break;
        }
    }

    public void GearboxPanel()
    {
        panels[3].SetActive(true);
        panelNo = 3;
        switch ((int)carManager.currentEngine.gearboxUpgrades)
        {
            case 0:
                tempEngine.gearboxUpgrades = Engine.GearboxUpgrades.Stock;
                break;
            case 1:
                tempEngine.gearboxUpgrades = Engine.GearboxUpgrades.Street;
                break;
            case 2:
                tempEngine.gearboxUpgrades = Engine.GearboxUpgrades.Sport;
                break;
            case 3:
                tempEngine.gearboxUpgrades = Engine.GearboxUpgrades.Race;
                break;
        }
    }

    public void BrakesPanel()
    {
        panels[4].SetActive(true);
        panelNo = 4;
        switch ((int)carManager.currentEngine.brakesUpgrades)
        {
            case 0:
                tempEngine.brakesUpgrades = Engine.BrakesUpgrades.Stock;
                break;
            case 1:
                tempEngine.brakesUpgrades = Engine.BrakesUpgrades.Street;
                break;
            case 2:
                tempEngine.brakesUpgrades = Engine.BrakesUpgrades.Sport;
                break;
            case 3:
                tempEngine.brakesUpgrades = Engine.BrakesUpgrades.Race;
                break;
        }
    }

    public void ResprayPanel()
    {
        panels[5].SetActive(true);
        panelNo = 5;
        
    }

    public void HideAll()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
    }

    public void ClearLog()
    {
        var assembly = Assembly.GetAssembly(typeof(UnityEditor.Editor));
        var type = assembly.GetType("UnityEditor.LogEntries");
        var method = type.GetMethod("Clear");
        method.Invoke(new object(), null);
    }
}
