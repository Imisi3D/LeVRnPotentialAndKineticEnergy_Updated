using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class MultiStepChecker
{
    public static bool IsHolderPresent(bool value)
    {
        MultiStepInteraction.HolderInfo instance = new MultiStepInteraction.HolderInfo();
        if (instance.holder != null)
        {
            value = true;
        }
        return (value);
    }
}

public class MultiStepInteraction
{
    public class HolderInfo
    {
        public object holder;
    }
}
