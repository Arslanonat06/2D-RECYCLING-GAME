using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public TMP_Text Skor;
    public int currentSkor = 0;
    public float spawnRate;
    public List<GameObject> itemPrefab = new List<GameObject>();

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnItem();
        Skor.text = "Skor: " + currentSkor.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSkor(int v)
    {
        currentSkor += v;
        Skor.text = "Skor: " + currentSkor.ToString();
    }

    public void SpawnItem()
    {
        int random = Random.Range(0,itemPrefab.Count);
        GameObject itemObj = Instantiate(itemPrefab[random]);

        Vector3 spawnpos = transform.position;
        spawnpos.z = 0f;

        itemObj.transform.position = spawnpos;
    }

}
