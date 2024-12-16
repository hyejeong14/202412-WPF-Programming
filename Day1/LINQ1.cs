int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// 아래 코드에서 y는 collection (배열 같은 것)
// => x의 요소 중 짝수면 열거
// => 결국 y가 내부적으로 람다표현식의 조건을 가지고 있다가
// => y를 사용해서 열거 할 때,x에 접근해서 조건을 만족하는 것을 꺼내는 것

var y = x.Where(n => n % 2 == 0);
//var y = x.Where(람다표현식);
x[1] = 100;
foreach(var e in y)
    Console.WriteLine(e);