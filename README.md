# changeCharacter
CodeLearn
Character limit: 3000
Huyền vừa học được cách biến đổi ký tự như sau.

Tất cả ký tự trong cặp dấu (): nếu là ký tự in hoa thì biến đổi thành ký tự in thường, ngược lại nếu là ký tự in thường thì biến đổi thành ký tự in hoa.
Ví dụ "(abC)" sẽ biến đổi thành "ABc".
Các cặp dấu () có thể lồng nhau.
Ví dụ "(aB(cDe))" sẽ biến đổi thành "AbcDe".
Vì "(aB(cDe))" -> "(aBCdE)" -> "AbcDe".
Cho chuỗi s chỉ gồm các ký tự chữ cái in thường, in hoa, '(' và ')', hãy biến đổi chuỗi s theo cách biến đổi của Huyền.

Ví dụ:

Với s = "(abC)", thì changeCharacter(s) = "ABc".
Với s = "(aB(cDe))", thì changeCharacter(s) = "AbcDe".
Đầu vào/Đầu ra:

[Thời gian] 0.5s với C++, 3s với Java và C#, 4s với Python, Go và JavaScript.
[Đầu vào] String 
s.length ≤ 105.
[Đầu ra] String.
Chuỗi s sau khi đã biến đổi.
