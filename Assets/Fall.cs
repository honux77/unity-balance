using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    bool end = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {        
        Debug.Log("충돌 감지");
        if (!end) {
            end = true;
            Canvas canvas = GameObject.Find("GameOverCanvas").GetComponent<Canvas>();
            canvas.GetComponent<Canvas> ().enabled = true;
        }
    }
}
