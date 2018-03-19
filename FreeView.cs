using UnityEngine;
using System.Collections;
public class FreeView : MonoBehaviour {
//�۲�Ŀ��
public Transform Target;
//�۲����
public float Distance = 0F;
//��ת�ٶ�
private float SpeedX=240;
private float SpeedY=120;

//�Ƕ�����
public float  MinLimitX = -40;
public float  MaxLimitX = 60;

public float  MinLimitY = -40;
public float  MaxLimitY = 60;

//��ת�Ƕ�
private float mX = 0.0F;
private float mY = 0.0F;

//������ž�����ֵ
private float MaxDistance=90;
private float MinDistance=-100F;
//�����������
private float ZoomSpeed=50F;

//�Ƿ����ò�ֵ
public bool isNeedDamping=true;
//�ٶ�
public float Damping=10F;

//�洢�Ƕȵ���Ԫ��
private Quaternion mRotation;

//������갴��ö��
private enum MouseButton
{
  //������
  MouseButton_Left=0,
  //����Ҽ�
  MouseButton_Right=1,
  //����м�
  MouseButton_Midle=2
}

//����ƶ��ٶ�
private float MoveSpeed=1.0F;
//��Ļ����
private Vector3 mScreenPoint;
//����ƫ��
private Vector3 mOffset;

void Start () 
{
  //��ʼ����ת�Ƕ�
  mX=transform.eulerAngles.x;
  mY=transform.eulerAngles.y;
}

void LateUpdate () 
{
  //����Ҽ���ҷ
  if(Target!=null && Input.GetMouseButton((int)MouseButton.MouseButton_Left))
  {
       //��ȡ�������
       mX += Input.GetAxis("Mouse X") * SpeedX * 0.02F;
       mY -= Input.GetAxis("Mouse Y") * SpeedY * 0.02F;
       //��Χ����
       mX = ClampAngle(mX, MinLimitX, MaxLimitX);
       mY = ClampAngle(mY,MinLimitY,MaxLimitY);
       
       //������ת
       mRotation = Quaternion.Euler(mY, mX, 0);
       //�����Ƿ��ֵ��ȡ��ͬ�ĽǶȼ��㷽ʽ
       if(isNeedDamping){
        transform.rotation = Quaternion.Lerp(transform.rotation,mRotation, Time.deltaTime*Damping);
       }else{
        transform.rotation = mRotation;
       }
  }

  //����������
  Distance-=Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed;
  Distance=Mathf.Clamp(Distance,MinDistance,MaxDistance);
  
  //���¼���λ��
  Vector3 mPosition = mRotation * new Vector3(0.0F, 0.0F, -Distance) + Target.position;

  //���������λ��
        if (isNeedDamping){
       transform.position = Vector3.Lerp(transform.position,mPosition, Time.deltaTime*Damping); 
      }else{
       transform.position = mPosition;
      }  
}


//�Ƕ�����
    private float  ClampAngle (float angle,float min,float max) 
    {
      if (angle < min) angle = min;
      if (angle > max) angle = max;
      return Mathf.Clamp (angle, min, max);
    }
}