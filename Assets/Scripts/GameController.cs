using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject launchpoint;
    public GameObject[] ballPrefabs;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {


    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            LauncherBall();
        }
    }

    private void LauncherBall()
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

    
}
