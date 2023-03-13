using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {
    Starting,
    Playing,
    Gameover
}

public enum GameTag {
    Platform,
    Player,
    LeftCorner,
    RightCorner,
    Collectable
}

public enum PrefKey {
    BestScore
}

[System.Serializable]

public class CollectableItem {
    public Collectable collectablePrefab;
    [Range(0f, 1f)]
    public float spawnRate;
}
public class DataStruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
