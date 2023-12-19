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
    public List<GameObject> itemPrefab = new List<GameObject>();
    public GameObject itemObj;
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
        if(itemObj!=null)
        {
            return;
        }

        int random = Random.Range(0,itemPrefab.Count);
        itemObj= Instantiate(itemPrefab[random]);

        Vector3 spawnpos = transform.position;
        spawnpos.z = 0f;

        itemObj.transform.position = spawnpos;
    }

}
