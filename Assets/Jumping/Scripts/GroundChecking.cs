using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecking : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (!collision.gameObject.CompareTag(GameTag.Platform.ToString())) return;

        var platformLanded = collision.gameObject.GetComponent<Platform>();

        if (!GameManager.Ins || !GameManager.Ins.player || !platformLanded) return;

        GameManager.Ins.player.PlatformLanded = platformLanded;
        GameManager.Ins.player.Jump();

        if (!GameManager.Ins.IsPlatformLanded(platformLanded.Id)) {
            int randScore = Random.Range(3, 8);
            GameManager.Ins.AddScore(randScore);
            GameManager.Ins.PlatformLandedIds.Add(platformLanded.Id);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
