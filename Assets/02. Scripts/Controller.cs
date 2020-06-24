using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    private Camera arCamera;
    private RaycastHit hit;


    // Start is called before the first frame update
    void Start()
    {
        arCamera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        //터치(클릭)

        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Touched");
        }

        //터치
        if(Input.GetMouseButton(0))
        {
            Debug.Log($"Touching {Time.time}");
          //Debug.Log("Touching" + Time.time);
        }

        //(2차원 좌표값) 터치 좌표값
        Vector2 pos = Input.mousePosition;

        //스크린 터치 좌표값을 3차원 Ray로 생성
        Ray ray = arCamera.ScreenPointToRay(pos);

        if (Input.GetMouseButtonDown(0)
        && Physics.Raycast(ray, out hit, 10.0f, 1<<8 ))
        {
            hit.collider.GetComponent<Renderer>().material.color = Color.red;
            //Debug.Log($"Position x={pos.x}, y={pos.y}");   

        }

        //화살표 입력값
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Clike Left Arrow");
        }

        if
            (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Clike Right Arrow");
        }


    }
}
