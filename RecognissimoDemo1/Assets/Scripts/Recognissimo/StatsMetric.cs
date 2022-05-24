using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class StatsMetric : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var metric = Stats.Create("MetricId");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
