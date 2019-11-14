using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawnManager : MonoBehaviour
{
    public List<GameObject> collectibles;
    public List<GameObject> multicolorCollectibles;

    private int randPrefab;
    private int randPosition;
    public GameObject itemToPaint;

    public GameObject player;
    private Vector3 spawnPosition;
    private float randPositionX;
    private float randPositionY;
    private float randPositionZ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            randPrefab = Random.Range(0, 3);

            itemToPaint = Instantiate(collectibles[randPrefab]);
            itemToPaint.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

            if (multicolorCollectibles.Count != 0)
            {
                randPosition = Random.Range(0, multicolorCollectibles.Count);
                multicolorCollectibles.Insert(randPosition, itemToPaint);
            }
            else
            {
                multicolorCollectibles.Add(itemToPaint);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            randPositionX = Random.Range(0f, 5f);
            randPositionY = Random.Range(0f, 5f);
            randPositionY = Random.Range(0f, 5f);

            spawnPosition = player.transform.position + (player.transform.forward * 5f) + new Vector3(randPositionX, randPositionY, randPositionZ);

            Instantiate(multicolorCollectibles[multicolorCollectibles.Count - 1], spawnPosition, multicolorCollectibles[multicolorCollectibles.Count - 1].transform.rotation);

            multicolorCollectibles.RemoveAt(multicolorCollectibles.Count - 1);
        }
    }
}
