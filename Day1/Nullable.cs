//C#
//reference type은 null이 될 수 있지만 value 타입은 nullable을 사용할 때만 null이 가능함

int n1 = null; //error
int? n2 = null; //ok null 가능 value 타입

//null인 객체를 ㅏ용하면 runtime에 죽게됨
//null은 꼭 필요할 때만 사용
int age = 0; //나이는 반드시 값이 있어야 함.
            // 따라서 이때는 int?는 피하자



// String Image Button Window 같은 reference 타입은 항상 null 가능
string s1 = null; //참조 타입은 null 가능
String? s2 = null
//그런데, string, Image,Button Window 같은 reference 타입은 항상 nulldl rksmd