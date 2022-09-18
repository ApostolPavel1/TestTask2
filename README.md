ЗАДАНИЕ 1. РЕЗЕРВНОЕ КОПИРОВАНИЕ ФАЙЛОВ.
Консольное приложение для резервного копирования файлов в архив.

В файле настроек хранятся пути для исходной и целевой папки.
При запуске программы происходит создание папки с временным штампом в целевой папке и копирование в неё всех доступных файлов из исходной. Требуется обрабатывать ситуации с невозможностью доступа к файлам в исходной папке.

Пункты со звездочкой являются дополнительными и не обязательны для выполнения.

* Файл настроек имеет формат JSON.
* Есть возможность указать несколько исходных папок.
* Ведется журналирование процесса копирования. Каждый запуск создает свой файл журнала. Уровень журналирования можно указать в файле настроек.
Примеры распределения событий:
•Error - Ошибки приложения. Например, те, которые вызвали неожиданное падение.
•Info - Основные события приложения: старт приложения, обработка одной исходной папки или обработанные ошибки.
•Debug - Отладочная информация. Например, скопирован отдельный файл



ЗАДАНИЕ 2. RSS ФИДЕР.

Графическое приложение для чтения RSS ленты с сайта.

В файле настроек хранится:
Лента, которую обрабатывает фидер. По умолчанию это (https://habr.com/rss/interesting/).
Частота обновления ленты приложением.  Настройки для прокси-сервера - адрес и учётные данные для подключения.

Основное окно должно содержать список элементов ленты (item): 
Каждый элемент ленты должен отображать название и дату публикации (поля item->title и item->pubDate ). Дата публикации статьи должна отображаться в удобном для чтения пользователю формате.
При нажатии на заголовок должен открываться браузер с переходом на выбранную статью (или в уже открытом браузере должна открываться ссылка).
Пользователь должен иметь возможность посмотреть описание статьи 
(поле item->description). Содержание описание выводится в виде обычного текста (как есть), без форматирования по тегам.

Данные должны периодически обновляться. Частота обновления должна быть взята из файла конфигурации.
При подключении к RSS ленте должны использоваться заданные настройки прокси-севера из файла конфигурации. 

Пункты со звездочкой являются дополнительными и не обязательны для выполнения.

* Файл настроек имеет формат XML.
* Имеется возможность изменить ленту в меню настроек.
* Имеется возможность изменить частоту обновления в меню настроек.
* Опции в меню настроек валидируются.
* Имеется возможность включить несколько лент. Пользователь должен иметь возможность включать и выключать ленты в окне приложения.
* Выводить описание в виде, форматированном по тегам.
* Иметь возможность переключения отображения описания в форматированном виде и без форматирования.
* Реализовать на asp.net mvc/blazor или asp.net spa с использование .net 5.0 / 6.0

Требования к присылаемым решениям.
•Готовые задания должны быть переданы в zip архиве. 
•Каждый из проектов должен находиться в своей папке и должен в обязательном порядке содержать отдельно исходный код приложения и отдельно собранную бинарную версию работающую в среде MS Windows 10. 
•Собранная программа не должна требовать настроек системы или нахождения определенных файлов в специфичном месте (не актуально для 2го задания, если выполнено на asp.net).
•Исходный код должен компилироваться средствами Visual Studio или Visual Studio Code.
•В архиве не должно быть неиспользуемых исходных кодов, ресурсов или промежуточных файлов сборки.
•Максимальное время на выполнение задания – 2 недели.
