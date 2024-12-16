object [] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//FirstOrDefault : 조건을 만족하는 1번째 값을 찾고, 없을 때는 디폴트값(0)을 반환
//int v = x.FirstOrDefault(n => n % 2 == 0); //object 타입은 %연산자 적용이 안됨.

var col = x.Cast<int>(); //x의 모든 요소를 int로 바라볼 수 있는 새로운 컬렉션 뷰 (복사본 아님)

int v = col.FirstOrDefault(n => n % 2 == 0); //여기서 n은 int라서 ok


//아래는 그냥 조건이 2개인 것
int v2 = col.FirstOrDefault(n => n % 2 == 0 && n > 5);
Console.WriteLine(v);
Console.WriteLine(v2);