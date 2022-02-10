using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public ObstacleGenerator obstacleGenerator;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * obstacleGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("nextObstacle")){
            obstacleGenerator.generateNextObstacleWithGap();
        }

        if(collision.gameObject.CompareTag("finish")){
            Destroy(this.gameObject);
        }
    }
}