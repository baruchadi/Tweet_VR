using UnityEngine;
using System.Collections;

public class Maze : MonoBehaviour {

    public int sizeX, sizeZ;

    public MazeFloor cellPrefab;

    private MazeFloor[,] cells;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Generate()
    {
        cells = new MazeFloor[sizeX, sizeZ];
        for (int x = 0; x < sizeX; x++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                CreateCell(x, z);
            }
        }
    }

    private void CreateCell(int x, int z)
    {
        MazeFloor newCell = Instantiate(cellPrefab) as MazeFloor;
        cells[x, z] = newCell;
        newCell.name = "Maze Cell " + x + ", " + z;
        newCell.transform.parent = transform;
        newCell.transform.localPosition = new Vector3(x - sizeX * 0.5f + 0.5f, 0f, z - sizeZ * 0.5f + 0.5f);
    }
}
