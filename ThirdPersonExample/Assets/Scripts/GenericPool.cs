using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericPool : MonoBehaviour
{
    Stack<GameObject> _pool = new Stack<GameObject>();

    [SerializeField]
    GameObject prefabToInstantiate;

    [SerializeField]
    int poolSize;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            CreateElement();
        }
    }
    GameObject CreateElement()
    {
        GameObject temporalElement = Instantiate(prefabToInstantiate, Vector3.zero, Quaternion.identity);
        temporalElement.GetComponent<BulletBehaviour>().bulletPool = this;
        _pool.Push(temporalElement);
        temporalElement.SetActive(false);
    }


    public GameObject GetElementFromPool()
    {
        GameObject toReturn = null;
        if(_pool.Count == 0)
        {
            CreateElement();
        }
        else
        {
            toReturn = _pool.Pop();
        }
        return toReturn;
    }

    public void ReturnToPool(GameObject element)
    {
        element.SetActive(false);
        

    }
}
