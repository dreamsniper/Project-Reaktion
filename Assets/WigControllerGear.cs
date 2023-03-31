using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reaktion;
using Kvant;

public class WigControllerGear : MonoBehaviour
{
    public ReaktorLink reaktor;
    public WigController wig;
    public float scale =1.0f; 

    private void Awake()
    {
        reaktor.Initialize(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Reaktor Output : Linear" + reaktor.Output + " " + DecibelToLinear(reaktor.Output));
        wig.length = DecibelToLinear(reaktor.Output * scale);
        wig.UpdateSimulationParameters(wig.target.position, wig.target.rotation, Time.deltaTime);

        //wig.ResetSimulationState();
    }

    private float DecibelToLinear(float db)
    {
        float linear = Mathf.Pow(10.0f, db / 20.0f);
        return linear;
    }
}
