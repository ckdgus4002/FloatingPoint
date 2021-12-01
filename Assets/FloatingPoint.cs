using UnityEngine;

/*
 * 263.3의 2진수 부동 소수점
    * 100000111.010011001100110...
 * 맨 앞에 있는 1 바로 뒤로 소수점을 옮겨서 표현하도록 변환합니다
    * 1.00000111010011001100110... * 2^8 
 * 이 방식에 따라서 263.3을 기록하면
    * 부호 비트(1 bit) : 0 (양수)
    * 지수 비트(8 bit) : 10000111 (127 + 8 = 135)
        * IEEE 754 표현 방식에서는 127 + 지수를 기록합니다.
    * 가수 비트(23 bit) : 00000111010011001100110
       * 약 0.29998779296875 
 */
public class FloatingPoint : MonoBehaviour
{
    [ContextMenu("Start")]
    private void Start()
    {
        var a = .1f * .1f; // 0.0100000007
        var b = .01f; // 0.00999999978
        if (a == b)
        {
            Debug.Log("부동소수점오차없음");
        }
        else
        {
            Debug.LogError($"부동소수점오차있음");
            Debug.LogError($"근접했는가? {Mathf.Approximately(a, b)}.");
        }
    }
}