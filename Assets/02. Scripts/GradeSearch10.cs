using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeSearch10 : MonoBehaviour
{
    public float offTime = 3;
    public float time = 0;
    private void Update()
    {
        time += Time.deltaTime;
        
        if(time >= offTime)
        {
            time = 0;
            transform.Find("Meet").gameObject.SetActive(false);
    
        }
    }
    public void Push()
    {
        // - Info 를 켜고 싶다
        transform.Find("Meet").gameObject.SetActive(true);
        
    }
}
