using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public GameObject player;

    public GameObject MiniMapCamera;

    private Vector3 offset;

    private Transform _player;
    private void Start()
    {
        _player = Camera.main.transform;
        transform.parent = null;
        transform.rotation = Quaternion.Euler(90.0f, 0, 0);
        transform.position = _player.position + new Vector3(0, 5.0f, 0);
        var rt = Resources.Load<RenderTexture>("MiniMapTexture");
        GetComponent<Camera>().targetTexture = rt;
        offset = transform.position - player.transform.position;
    }
    private void LateUpdate()
    {
        var newPosition = _player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
        transform.rotation = Quaternion.Euler(90, _player.eulerAngles.y, 0);
        transform.position = player.transform.position + offset;
    }
}
