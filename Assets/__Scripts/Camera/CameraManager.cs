using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject target; // Ÿ�� -Player
    public float moveSpeed; //�Ѵ� �ӵ�

    private Vector3 targetPosition; //����� ����ġ��


    private void Update()
    {
        if(target.gameObject != null)
        {       //this- ī�޶� ����Ŵ. -10�� �����ؾ��Ѵ�.
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);
            // lerp �� A���� B�������� ������������ �߰� ���� ���Ͻ�Ų��. ex) (1,10,0.5f) = 5  (5,10,0.5f) = 7.5 
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }

}
