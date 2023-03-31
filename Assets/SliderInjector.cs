using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Reaktion;

public class SliderInjector : InjectorBase
{
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        dbLevel = slider.value;
    }
}
