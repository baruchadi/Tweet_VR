using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        CreateRoom();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RegenRoom();
        }
    }

    public Maze p_maze;
    private Maze i_maze;


    private void CreateRoom() {
        i_maze = Instantiate(p_maze) as Maze;
        i_maze.Generate();
    }
    private void RegenRoom() {
        Destroy(i_maze.gameObject);
        CreateRoom();
    }
}
