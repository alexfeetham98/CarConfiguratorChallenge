using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bodywork : MonoBehaviour
{

    public enum Paintjob { Stock, Red, Blue, Orange }

    public Paintjob paintjob;

    public Material primary;
    public Material secondary;
    public Material interiorPrimary;
    public Material interiorSecondary;
    public Material seatsPrimary;
    public Material seatsSecondary;



    [SerializeField]
    private Color32 stockPrimary = new Color32(255, 107, 0, 255);
    [SerializeField]
    private Color32 stockSecondary;
    [SerializeField]
    private Color32 stockInteriorPrimary = new Color32(255, 107, 0, 255);
    [SerializeField]
    private Color32 stockInteriorSecondary;
    [SerializeField]
    private Color32 stockSeatsPrimary = new Color32(255, 107, 0, 255);
    [SerializeField]
    private Color32 stockSeatsSecondary;

    private Color32 papaya = new Color32(255, 107, 0, 255);

    void Start()
    {
        paintjob = Paintjob.Stock;
    }

    void Update()
    {
        switch(paintjob)
        {
            case Paintjob.Stock:
                primary.SetColor("_Color", Color.black);
                interiorPrimary.SetColor("_Color", Color.black);
                seatsPrimary.SetColor("_Color", Color.black);
                break;
            case Paintjob.Red:
                primary.SetColor("_Color", Color.red);
                interiorPrimary.SetColor("_Color", Color.red);
                seatsPrimary.SetColor("_Color", Color.red);
                break;
            case Paintjob.Blue:
                primary.SetColor("_Color", Color.blue);
                interiorPrimary.SetColor("_Color", Color.blue);
                seatsPrimary.SetColor("_Color", Color.blue);
                break;
            case Paintjob.Orange:
                primary.SetColor("_Color", papaya);
                interiorPrimary.SetColor("_Color", papaya);
                seatsPrimary.SetColor("_Color", papaya);
                break;
        }
    }

    public Material Primary
    {
        get { return primary; }
        set { primary = value; }
    }
}
