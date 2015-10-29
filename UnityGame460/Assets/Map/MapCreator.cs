using UnityEngine;
using System.Collections;

public class MapCreator : MonoBehaviour {
    //Test
    //Test again
    public GameObject groundTile, wallTile;
    public int width, height;

	// Use this for initialization
	void Start () {
	    for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                GameObject created = groundTile;
                if(Random.Range(0f, 1f) < 0.2f)
                {
                    created = wallTile;
                }
                Instantiate(created, new Vector3(x, 0, y), Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
