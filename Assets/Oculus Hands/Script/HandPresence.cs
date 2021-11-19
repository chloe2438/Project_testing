using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPresence : MonoBehaviour
{
    public GameObject handModelPrefab;

    private GameObject spawnedHandModel;

    void Start()
    {
        spawnedHandModel = Instantiate(handModelPrefab, transform);
    }

    // Update is called once per frame
    void Update()
    {
        spawnedHandModel.SetActive(true);
    }
}
