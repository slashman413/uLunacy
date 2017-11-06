using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{
	static public GameController instance;

	private List<Biology> enemyTeam;
	private List<Biology> playerTeam;

	// constructor
	private GameController() 
	{
	}
		
	int AddEnemy (Biology biology)
	{
		enemyTeam.Add (biology);
	}

	int AddPlayer (Biology biology)
	{
		playerTeam.Add (biology);
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (enemyTeam.Count
	}
}
