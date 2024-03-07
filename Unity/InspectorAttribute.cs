using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 11. AddComponentMenu(string)
// 해당 스크립트를 AddComponent 메뉴에 추가하는 속성
[AddComponentMenu("MyScript")]

// 10. RequireComponent(Type)
// 해당 컴포넌트를 필수로 추가해야 하는 속성
[RequireComponent(typeof(Rigidbody))]
public class InspectorAttribute : MonoBehaviour
{
   // 1. Header (string)
   // 인스펙터 내에 타이틀을 달 수 있는 속성
   [Header("Header")] 
   public int num1;
   
   // 2. Space(float)
   // 필드 사이에 여백을 주는 속성
   [Space(10f)] 
   public float num2;
   
   // 3. Range(float , float)
   // 변수의 값을 슬라이더 형식으로 표시 , 최소 및 최대 값을 정해주는 속성
   [Range(0.5f, 1.5f)] 
   public float num3;
   
   // 4. Multiline(int)
   // 문자열을 작성하기 편하도록 라인의 수를 늘려주는 속성
   [Multiline(3)] 
   public string str1;
   
   // 5. TextArea(int , int)
   // MultiLine과 비슷하지만, 라인의 수를 정해주는 것이 아닌, 가로 및 세로의 크기를 정해주는 속성
   [TextArea(3, 5)] 
   public string str2;
   
   // 6. SerializeField
   // private 변수도 인스펙터에 노출시키는 속성
   [SerializeField]
   private int num4;
   
   // 7. Tooltip(string)
   // 변수에 마우스를 올렸을 때 설명을 보여주는 속성
   [Tooltip("This is a tooltip")]
   public string str3;
   
   // 8. HideInInspector
   // 변수를 인스펙터에 노출시키지 않는 속성
   [HideInInspector]
   public bool isShow;

   
   // 9. System.Serializable
   // 클래스 혹은 구조체를 인스펙터에 노출시키는 속성
   [System.Serializable]
   struct Stats
   {
      public int health;
      public int damage;
   }

   // 12. ContextMenu(string)
   // 해당 함수를 인스펙터에 노출시키는 속성
   [ContextMenu("Do Something")]
   void Func()
   {
      
   }
   

}
