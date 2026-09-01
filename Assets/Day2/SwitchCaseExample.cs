using UnityEngine;

enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class SwitchCaseExample : MonoBehaviour
{
    void Start()
    {
        // 분기류
        // 내가 원하는 값과 같냐 다르냐에 따라서 실행할 코드 분기를 나눌 수 있다.
        
        /**
        switch (검사할 변수)
        {
            case 값1:
            {
                실핼할 코드
            }
            
            csae 값2:
            {
                실핼할 코드...
            }
            
            default:        // (옵션 아무런 case에 해당하지 않는다면..)
            {
                실행할 코드
            }
        }
        **/
        
        // [분기문(switch-case) 이용]
        
        // 1번 문제
        // 변수 today를 선언하고.. 요일에 따라
        // "오늘은 땡요일입니다!" 를 출력해주는 코드를 작성하세요
        
        // 2번 문제
        // 변스 score를 선언하고.. 점수(0~100)에 따라
        // 100: "A+", 90~99: "A", 80~89: "B", 70~79: "C", 60~69: "D", 60미만 "F"
        // 를 출력해주는 코드를 작성하세요.
        
        Day today = Day.Monday;
        
        switch (today)
        {
            case Day.Monday:
            {
                Debug.Log("오늘은 월요일입니다");
                break;
            }
            
            case Day.Tuesday:
            {
                Debug.Log("오늘은 화요일입니다");
                break;
            }
            
            case Day.Wednesday:
            {
                Debug.Log("오늘은 수요일입니다");
                break;
            }
            
            case Day.Thursday:
            {
                Debug.Log("오늘은 목요일입니다");
                break;
            }
            
            case Day.Friday:
            {
                Debug.Log("오늘은 금요일입니다");
                break;
            }
            
            case Day.Saturday:
            {
                Debug.Log("오늘은 토요일입니다");
                break;
            }
            
            case Day.Sunday:
            {
                Debug.Log("오늘은 월요일입니다");
                break;
            }
            
            default:
            {
                Debug.Log("?");
                break;
            }
        }

        int score = 95;
        
        switch (score / 10)
        {
            case 10:
            {
                Debug.Log("A+");
                break;
            }
            
            case 9:
            {
                Debug.Log("A");
                break;
            }
            
            case 8:
            {
                Debug.Log("B");
                break;
            }
            
            case 7:
            {
                Debug.Log("C");
                break;
            }
            
            case 6:
            {
                Debug.Log("D");
                break;
            }
            
            default:
            {
                Debug.Log("F");
                break;
            }
        }
    }
}
