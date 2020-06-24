using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeSearch1 : MonoBehaviour
{
    public float offTime = 3;
    public float time = 0;
    private void Update()
    {
        time += Time.deltaTime;
        
        if(time >= offTime)
        {
            time = 0;
            transform.Find("Info1").gameObject.SetActive(false);
        }
    }
    public void Push()
    {
        // - Info 를 켜고 싶다
        transform.Find("Info1").gameObject.SetActive(true);
    }
}
