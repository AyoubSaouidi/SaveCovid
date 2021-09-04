using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{

    // Static Reference of this object
    public static Pool instance;
    public ObjectToPool[] objectsToPool;
    public List<ObjectToPool> objectsPool;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        objectsPool = new List<ObjectToPool>();
        foreach (ObjectToPool objectToPool in objectsToPool)
        {
            for(int i=0; i<objectToPool.amount;i++){
                ObjectToPool obj = new ObjectToPool();
                obj.name = objectToPool.name;
                obj.gameObject = Instantiate(objectToPool.gameObject);
                obj.amount = 1;
                obj.gameObject.SetActive(false);
                objectsPool.Add(obj);
            }
        }

    }

    public GameObject getObjectFromPool(string name){

        foreach (ObjectToPool objectToPool in objectsPool)
        {
            if(objectToPool.name == name) {
                if(!objectToPool.gameObject.activeInHierarchy){
                    objectToPool.gameObject.SetActive(true);
                    return objectToPool.gameObject;
                }
            }
        }

        return null;
    }
}
