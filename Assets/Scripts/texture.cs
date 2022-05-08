using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texture : MonoBehaviour
{
    private Transform tile;
    private float tileX;
    private float tileY;
    Mesh mesh;
    private Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        mesh = GetComponent<MeshFilter>().mesh;
        tile = GetComponent<Transform>();
        //tileX = tile.lossyScale.x;
        tileX = 30;
        tileY = tile.lossyScale.y;
    }

    void Update()
    {
        mat.mainTextureScale = new Vector2((mesh.bounds.size.x *
transform.localScale.x) / 100 * tileX, (mesh.bounds.size.y * transform.localScale.y) / 100 * tileX);
    }
}
