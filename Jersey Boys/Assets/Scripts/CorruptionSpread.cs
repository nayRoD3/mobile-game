using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CorruptionSpread : MonoBehaviour
{
	GameObject[] zombies;

	[SerializeField]
	private Tilemap map;

	[SerializeField]
	private TileBase corruptedTile;

	[SerializeField]
	private MapManager mapManager;

	internal void MakeCorrupted(Vector3Int position)
	{
		TileBase tile = map.GetTile(position);
		if (tile == null)
		{
			return;
		}
		else
		{
			map.SetTile(position, corruptedTile);
		}

	}

	private void Update()
	{
		zombies = GameObject.FindGameObjectsWithTag("Zombie");
		for(int i = 0; i< zombies.Length;i++)
		{
			Vector2 ZombiePosition = zombies[i].transform.position;
			Vector3Int gridposition = map.WorldToCell(ZombiePosition);
			MakeCorrupted(gridposition);
		}
	}
}
