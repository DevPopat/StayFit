using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstacle;
    
    public float speedMultiplier;

    public float minimumSpeed;
    public float maximumSpeed;
    public float currentSpeed;

    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = minimumSpeed;
        generateObstacle();
        
    }

    public void generateNextObstacleWithGap(){
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateObstacle", randomWait);
    }

    void generateObstacle() {
        GameObject obstacleIns = Instantiate(obstacle, transform.position, transform.rotation);
        obstacleIns.GetComponent<ObstacleScript>().obstacleGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < maximumSpeed){
            currentSpeed += speedMultiplier;
        }
    }
}
