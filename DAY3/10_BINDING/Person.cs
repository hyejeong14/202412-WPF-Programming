// 아래 처럼만 만들면 
// => Person 객체의 Name, Address 를
// => UI 의 컨트롤(TextBox)과 연결가능합니다
// => 단, 객체의 상태가 변경될때 연결된 컨트롤에 통보가 안됩니다.(관찰자 패턴이아님)

/*class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
}*/
//public List<Person과 연결된 ui 객체의 약속된 함수> controls;
//      => 결국 delegate(event) 문법과 같음
//name 또는 Address가 변경되면 자신과 연결된 모든 UI 객체(observer)에 통보
//위 내용을 약속된 방식으로 구현하면 됨


//약속된 방식 : INotifyPropertyChange 라는 인터페이스 구현
using System.ComponentModel;

class Person : INotifyPropertyChanged
{
    //PropertyChanged => delegate, 함수포인터???'
    //UI(textbox)가 person객체 pe에 연결될 때 아래 필드에 함수를 등록
    //속성이 변경되면 아래 등록된 함수를 호출
    public event PropertyChangedEventHandler? PropertyChanged;

    //set에서 통보해야하므로 아래처럼 auto property로는 안됨
    //public string Name { get; set; }
    //public string Address { get; set; }

    //1. 필드 먼저 만들기
    private string name;
    private string address;

    //2. property만들기
    public string Name
    {
        get { return name; }
        set
        {
            name = value;
            if (PropertyChanged != null)
            {
                //아래 코드는 등록된 함수를 호출하는 코드
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

    }

    public string Address
    {
        get { return address; }
        set
        {
            address = value;
            if (PropertyChanged != null)
            {
                //아래 코드는 등록된 함수를 호출하는 코드
                //객체의 주소와 어떤 property가 변경되었는지 알림
                PropertyChanged(this, new PropertyChangedEventArgs("Address"));
            }
        }

    }
    public override string ToString()
    {
        return $"{Name}, {Address}";
    }

}