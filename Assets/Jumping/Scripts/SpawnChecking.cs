using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChecking : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag(GameTag.Platform.ToString())) {
            var platformCol = col.GetComponent<Platform>();

            if (!platformCol || !GameManager.Ins || !GameManager.Ins.LastPlatformSpawned) return;

            if (platformCol.Id == GameManager.Ins.LastPlatformSpawned.Id) {
                GameManager.Ins.SpawnPlatform();
            }

        }
    }
}
