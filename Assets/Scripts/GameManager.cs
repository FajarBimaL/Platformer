using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject box;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _mousePos.z = 0;

            Instantiate(box, _mousePos, Quaternion.identity);
        }
    }
}
