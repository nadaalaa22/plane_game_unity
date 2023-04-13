using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoving : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer meshRender;
    private float speed = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = meshRender.material.mainTextureOffset;
        offset = offset + new Vector2(0, speed * Time.deltaTime);
        meshRender.material.mainTextureOffset = offset;
    }
}
