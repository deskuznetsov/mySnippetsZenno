﻿//Есть 2 способа сохранить профиль: преобразовать текущий профиль в 
//строку и сохранить, либо воспользоваться методом Profile.Save.
//В первом случае сохранятся только данные профиля, во втором случае - 
//можно выбрать ещё и сохранение данных прокси, плагинов,
//локального хранилища (local storage)

//Первый способ:
string strProfile = project.Profile.ToString(); //преобразовываем профиль в строку
File.WriteAllText(project.Directory + @"\Вспомогательные файлы\profile.txt", strProfile); //сохраняем профиль в файл D:\profile.txt

//Второй способ:
project.Profile.Save(project.Directory + @"\Вспомогательные файлы\profile.zpprofile", true, true, true); //сохраняем профиль в файл D:\profile.zpprofile
//расширение файла обязательно должно быть .zpprofile, иначе .zpprofile будет добавлено автоматически
//второй параметр (bool saveProxy) - сохранять ли в файле информацию о прокси
//третий параметр (bool savePlugins) - сохранять ли в файле информацию о плагинах браузера
//четвёртый параметр (bool saveLocalStorage) - сохранять ли в файле информацию локального хранилища