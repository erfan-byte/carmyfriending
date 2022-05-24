using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Roadspawner : MonoBehaviour
{
    public List<GameObject> RoadsFolder;
    private float offset = 30f;

    // Start is called before the first frame update
    void Start()
    {
        if (RoadsFolder != null && RoadsFolder.Count > 0 )
        {
            RoadsFolder = RoadsFolder.OrderBy(r => r.transform.position.z).ToList();
        }
    }
     
    public void MoveRoad()
    {
        GameObject movedRoad = RoadsFolder[0];
        RoadsFolder.Remove(movedRoad);
        float newZ = RoadsFolder[RoadsFolder.Count - 1].transform.position.z + offset;
        movedRoad.transform.position = new Vector3(0, 0, newZ);
        RoadsFolder.Add(movedRoad);
    }
}
