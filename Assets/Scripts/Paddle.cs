using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float screenWidthInUnits = 16;

    [SerializeField] private float xMin = 1f;

    [SerializeField] private float xMax = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnit = Input.mousePosition.x / 1080 * screenWidthInUnits;
        float xPos = Mathf.Clamp(mousePosInUnit, xMin, xMax);
        Vector2 paddlePos = new Vector2(xPos, transform.position.y);
        transform.position = paddlePos;
    }
}
