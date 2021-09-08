using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject launchpoint;
    public GameObject[] ballPrefabs;
    float speed = 0.0f;
    int score = 0;
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
     scoreText = GameObject.Find("Scorenum").GetComponent<Text>();
    }

    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            speed += 0.5f;
            if (speed > 150)
            {
                speed = 150;
            }
        }
        if(Input.GetButtonUp("Fire1"))
        {
            LauncherBall(speed);
            speed = 0;
        }
    }

    private void LauncherBall(float speed)
    {
        // 弾を発射する場所を取得
        Vector3 ballPosition = launchpoint.transform.position;
        // 上で取得した場所に、"bullet"のPrefabを出現させる
        GameObject newBall = Instantiate(SelectBall(), ballPosition, transform.rotation);
        // 出現させたボールのforward(z軸方向)
        Vector3 direction = newBall.transform.forward;
        // 弾の発射方向にnewBallのz方向(ローカル座標)を入れ、弾オブジェクトのrigidbodyに衝撃力を加える
        newBall.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);
  
    }

    GameObject SelectBall()
    {
        int index = Random.Range(0, ballPrefabs.Length);
        return ballPrefabs[index];
    }

    public void countscore(int num)
    {
        score += num;
        scoreText.text = "score : " + score;
    }
    
}
