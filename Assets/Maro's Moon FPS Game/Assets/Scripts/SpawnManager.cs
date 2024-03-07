using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] meteorsPrefabs;
    [SerializeField] private float spawnCooldown;
    private float cooldownTimer;
    private Vector3 spawnPosition;
    private int currentScore;
    public Text scoreText;

    private void Start() {
        float cooldownTimer = spawnCooldown;
    }
    
    private void Update() {
        UpdateScore();
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            GenerateRandomMeteor();
            cooldownTimer = spawnCooldown;
        }
    }

    private void GenerateRandomMeteor() 
    {
        int firstPosition = Random.Range(0, 3);
        float secondPosition = Random.Range(-75f, 75f);
        switch (firstPosition)
        {
            case 0:
                spawnPosition.x = 75;
                spawnPosition.z = secondPosition;
                break;

            case 1:
                spawnPosition.x = -75;
                spawnPosition.z = secondPosition;
                break;

            case 2:
                spawnPosition.z = 75;
                spawnPosition.x = secondPosition;
                break;

            case 3:
                spawnPosition.z = 75;
                spawnPosition.x = secondPosition;
                break;    
        }
        float thirdPosition = Random.Range(10f, 30f);
        spawnPosition.y = thirdPosition;
        int meteorIndex = Random.Range(0, meteorsPrefabs.Length);
        Instantiate (meteorsPrefabs[meteorIndex], spawnPosition, meteorsPrefabs[meteorIndex].transform.rotation);
    }

    private void UpdateScore()
    {
        currentScore = Scoring.GetScore();
        scoreText.text = "Score: " + currentScore;
    }
}
