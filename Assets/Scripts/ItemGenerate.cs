using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerate : MonoBehaviour
{
    [SerializeField] Transform _root;
    [SerializeField] GameObject _itemPrefab;

    private void Awake()
    {
        for (int i = 0; i < 19; i++)
        {
            var item = Instantiate(_itemPrefab, _root);
            item.transform.position = new Vector3(0, 1, i * -5 - 5);
        }
    }
}
