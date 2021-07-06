using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePool : MonoBehaviour
{
    public static FirePool current;
    public GameObject Fire;

    private List<GameObject> pool;

    private void Awake()
    {
        if (current != null)
        {
            Destroy(this);
        }
        else
        {
            current = this;
        }
    }

    private void Start()
    {
        pool = new List<GameObject>(10);
        for (int i = 0; i != 10; i++)
        {
            pool.Add(Instantiate(Fire));
            pool[i].SetActive(false);
        }
    }

    public GameObject GiveFire()
    {
        for(int i = 0; i!= pool.Count; i++)
        {
            if (!pool[i].activeSelf)
            {
                pool[i].SetActive(true);
                return pool[i];
            }
        }
        pool.Add(Instantiate(Fire));
        return (pool[pool.Count - 1]);
    }


}
