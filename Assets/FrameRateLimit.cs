using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FrameRateLimit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 1;//2 or 3 or 4


        Application.targetFrameRate = -1;
    }
}
