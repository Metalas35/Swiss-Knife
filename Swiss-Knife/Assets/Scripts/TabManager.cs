using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TabManager : MonoBehaviour
{
    private readonly List<GameObject> _tabs = new List<GameObject>();

    public Button OutputFormatterBtn;
    public Button ReelSimulatorBtn;
    public Button CompressionBtn;

    public GameObject OutputFormatterPnl;
    public GameObject ReelSimulatorPnl;
    public GameObject CompressionPnl;

    // Start is called before the first frame update
    void Start()
    {
        OutputFormatterPnl.SetActive(true);
        ReelSimulatorPnl.SetActive(false);
        CompressionPnl.SetActive(false);

        _tabs.Add(OutputFormatterPnl);
        _tabs.Add(ReelSimulatorPnl);
        _tabs.Add(CompressionPnl);
    }

    public void ActivateTab(int index)
    {
        foreach (var panel in _tabs)
        {
            panel.SetActive(false);
        }

        _tabs[index].SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
