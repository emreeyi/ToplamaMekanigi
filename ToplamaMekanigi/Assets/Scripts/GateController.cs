using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GateController : MonoBehaviour
{
    public TMP_Text gateNumberText = null;
    public enum GateType
    {
        PositiveGate,
        NegativeGate

    }
    public GateType gateType;
    public int gateNumber;
    public int GetGateNumber()
    {
        return gateNumber;
    }

    void Start()
    {
        RandomGateNumber();
    }
    private void RandomGateNumber()
    {
        switch(gateType)
        {
            case GateType.PositiveGate:gateNumber = Random.Range(1, 10);
                gateNumberText.text = gateNumber.ToString();
                break;
            case GateType.NegativeGate: gateNumber = Random.Range(-10, -1);
                gateNumberText.text = gateNumber.ToString();
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
