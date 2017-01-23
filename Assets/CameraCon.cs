using UnityEngine;
using System.Collections;

public class CameraCon : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
	}

    void Update()
    {
        Quaternion gyro = Input.gyro.attitude;                                               //ジャイロの震度をとる
        gyro = Quaternion.Euler(90, 0, 0) * (new Quaternion(-gyro.x, -gyro.y, gyro.z, gyro.w)) ;  //スマホは横向きなので９０をかけてあげる。角度の計算(行列)なので掛け算 

        this.transform.rotation = gyro;
    }
}
