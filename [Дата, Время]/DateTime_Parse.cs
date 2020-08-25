//Любая из этих строк преобразуется в объект DateTime 21.05.2020 00:22:10
string input0 = "21.05.2020 00:22:10";
string input1 = "21-05-2020 00:22:10";
//а вот если строка будет вида "05/21/2020 00:22:10", т.е. сначала месяц, а после число (как приято в en-US) — получим ошибку распознавания
string input2 = "21/05/2020 00:22:10";
string input3 = "21/05.2020 00:22:10";
string input4 = "21 мая 2020 00:22:10";

DateTime dt = DateTime.Parse(input4); //все строки от input0 до input4 преобразуются в одинаковый формат 21.05.2020 00:22:10
return dt;