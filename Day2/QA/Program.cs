// C/C++은 double을 int에 넣을 때 에러 없이 경고 발생
// c#을 비롯한 대부분의 언어는 컴파일 에러 발생

double d = 3.4;
//int n = d; //컴파일러가 d가 double임을 알 수 있기 때문에 컴파일 시 에러 발생

object obj = d; // ok. C#의 모든 값은 object로 가리킬 수 있음.

//int n1 = obj; //컴파일 에러

int n2 = (int)obj; //런타임에러