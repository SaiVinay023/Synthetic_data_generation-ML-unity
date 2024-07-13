using System;
using UnityEngine;
using UnityEngine.Perception.Randomization.Parameters;
using UnityEngine.Perception.Randomization.Randomizers;


[AddRandomizerMenu("Perception/My Light Randomizer")]
public class MyLightRandomizer : Randomizer
{
    public FloatParameter lightIntensityParameter;
    public FloatParameter lightRangeParameter;
    public FloatParameter lightOuterAngleParameter;
    public ColorRgbParameter color;

    protected override void OnIterationStart()
    {
       
    }
}