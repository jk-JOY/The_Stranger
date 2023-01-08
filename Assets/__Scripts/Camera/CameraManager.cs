using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject target; // 타겟 -Player
    public float moveSpeed; //쫓는 속도

    private Vector3 targetPosition; //대상의 현위치값


    private void Update()
    {
        if(target.gameObject != null)
        {       //this- 카메라를 가르킴. -10을 유지해야한다.
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);
            // lerp 는 A값과 B값사이의 선형보간으로 중간 값을 리턴시킨다. ex) (1,10,0.5f) = 5  (5,10,0.5f) = 7.5 
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }

}
