using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaManager : MonoBehaviour
{
    private float xMinimum, xMaximum, zMinimum, zMaximum;
    public GameObject manaPrefab;
    private bool canSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        GameObject myTerrain = this.gameObject.transform.parent.gameObject;
        xMinimum = myTerrain.transform.position.x;
        zMinimum = myTerrain.transform.position.z;
        Vector3 terrainArea = myTerrain.GetComponent<Terrain>().terrainData.size;
        xMaximum = xMinimum + terrainArea.x;
        zMaximum = zMinimum + terrainArea.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn && DataHolder.numMana < 20){
            DataHolder.addMana();
            spawnMana();
            canSpawn = false;
            StartCoroutine(countDownSpawn());
        }
        
    }

    void spawnMana(){
        Vector3 pos = new Vector3(Random.Range(xMinimum, xMaximum), 0, Random.Range(zMinimum, zMaximum));
        pos.y = Terrain.activeTerrain.SampleHeight(pos);
        GameObject newGameObject = Instantiate(manaPrefab, pos, Quaternion.identity);
        newGameObject.transform.parent = this.transform;
    }
    IEnumerator countDownSpawn(){
        yield return new WaitForSeconds(5);
        canSpawn = true;        
    }
}
