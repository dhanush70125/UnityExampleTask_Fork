using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string spawned = "SpawnedObjects";
    [SerializeField] private Material highlightmaterial;
    [SerializeField] private Material defaultMaterial;


    private Transform _selection_;


    // Update is called once per frame
    private List<GameObject> prefabs = new List<GameObject>();
    void Update()
    {

        if (_selection_ != null)
        {
            var selectionRenderer = _selection_.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection_ = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            
            var selection = hit.transform;
            if (selection.CompareTag(spawned))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightmaterial;
                    
                }

                _selection_ = selection;
                addPrefab(_selection_.gameObject);
            }
        }

    }
    void addPrefab(GameObject currPrefab)
    {
        foreach (GameObject prefab in prefabs)
        {
            if(prefabs == null)
            {
                prefabs.Add(currPrefab);
                Debug.Log("Added");
            }
            else if (currPrefab.transform.position != prefab.transform.position)
            {
                prefabs.Add(currPrefab);
                Debug.Log("Added");
            }
        }
    }
}
