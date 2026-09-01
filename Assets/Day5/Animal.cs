using UnityEngine;

public abstract class Animal // 추상 클래스 : new 연ㄴ산자를 이용해서 객체를 못만듬...
{
    // protected: 외부에서는 접근이 불가능하지만, 내부 혹은 자식 클래스에서는 접근 가능
    protected string _name = string.Empty;
    protected float _height = 0f;
    protected double _weight = 0d;
    
    
    // virtual: 하위 클래스에서 재정의 가능함을 알려주는 키워드
    // public virtual void (함수 이름)()
    // {
    // Debug.Log("모든 동물 클래스는 Introduce를 구현해야 합니다. 이 메시지가 뜨면 코드를 주의깊게 확인하세요.");
    // Debug.Log("[Error] 김홍일 개발자를 찾아오세요.");
    // }
    public abstract void Introduce(); // 추상 메서드 -> 구현이 없는 메서드이므로 하위 클래스에서 무조건 구현을 해야 하는 클래스

    public void Run()
    {
        Debug.Log($"[{_name} 뛰는 중!] 속도: {100 - (_height / _weight)}");
    }
}
