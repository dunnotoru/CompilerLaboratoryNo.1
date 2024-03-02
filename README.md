Компилятор
Разработка текстового редактора с функциями языкового процессора.

Оглавление
Лабораторная работа №1: Разработка пользовательского интерфейса (GUI) для языкового процессора
Лабораторная работа №2: Разработка лексического анализатора (сканера)
Лабораторная работа №3: Разработка синтаксического анализатора (парсера)
Лабораторная работа №4: Нейтрализация ошибок (метод Айронса)
Лабораторная работа №5: Включение семантики в анализатор. Создание внутренней формы представления программы
Лабораторная работа №6: Реализация алгоритма поиска подстрок с помощью регулярных выражений
Лабораторная работа №7: Реализация метода рекурсивного спуска для синтаксического анализа
Лабораторная работа №1: Разработка пользовательского интерфейса (GUI) для языкового процессора
Тема: разработка текстового редактора с возможностью дальнейшего расширения функционала до языкового процессора.

Цель работы: разработать приложение с графическим интерфейсом пользователя, способное редактировать текстовые данные. Это приложение будет базой для будущего расширения функционала в виде языкового процессора.

Язык реализации: C#, WPF.

Интерфейс текстового редактора
Главное окно программы

Получившийся текстовый редактор имеет следующие элементы:
Заголовок окна.

Содержит информацию о названии открытого файла, полного пути к нему, а также о том, сохранен ли он на текущий момент (наличие символа звездочки справа от названия означает наличие несохраненных изменений).

Меню

Пункт меню	Подпункты
Файл	Главное окно программы
Правка	Правка
Текст	Текст
Пуск	—
Справка	Справка
Панель инструментов

Панель инструментов

Создать
Открыть
Сохранить
Изменить размер текста
Отменить
Повторить
Копировать
Вырезать
Вставить
Пуск
Вызов справки
О программе
Область редактирования

Поддерживаются следующие функции:

Изменение размера текста
Открытие файла при перетаскивании его в окно программы
Базовая подсветка синтаксиса
Нумерация строк
Область отображения результатов

В область отображения результатов выводятся сообщения и результаты работы языкового процессора.

Поддерживаются следующие функции:

Изменение размера текста
Отображение ошибок в виде таблицы
Строка состояния

В дополнении к информации, выводимой в заголовке окна, показываются текушие номера строки и столбца, где находится курсор.

Справочная система
Разделы справочной системы открываются как HTML-документы в браузере.

Раздел	Изображение
Вызов справки	Вызов справки
О программе	О программе
Вывод сообщений
Сообщение	Описание	Изображение
Закрытие окна программы	Появляется при закрытии программы нажатием крестика или комбинацией клавиш при наличии несохраненных изменений	Закрытие окна программы
Сохранение изменений	Появляется при попытке открыть существующий файл или создать новый при наличии несохраненных изменений	Сохранение изменений
Лабораторная работа №2: Разработка лексического анализатора (сканера)
Тема: разработка лексического анализатора (сканера).

Цель работы: изучить назначение лексического анализатора. Спроектировать алгоритм и выполнить программную реализацию сканера.

№	Тема	Пример верной строки	Справка
42	Объявление и инициализация целочисленной константы в СУБД PostgreSQL	DECLARE product_price CONSTANT INTEGER := 150;	ссылка
В соответствии с вариантом задания необходимо:

Спроектировать диаграмму состояний сканера.
Разработать лексический анализатор, позволяющий выделить в тексте лексемы, иные символы считать недопустимыми (выводить ошибку).
Встроить сканер в ранее разработанный интерфейс текстового редактора. Учесть, что текст для разбора может состоять из множества строк.
Входные данные: строка (текст программного кода).

Выходные данные: последовательность условных кодов, описывающих структуру разбираемого текста с указанием места положения и типа.

Примеры допустимых строк
DECLARE
product_price CONSTANT INTEGER = +150;
DECLARE total_amount CONSTANT INTEGER := -150;
DECLARE productPrice CONSTANT INTEGER := +150;
DECLARE expense_1_amount CONSTANT INTEGER := -50;
DECLARE product_price CONSTANT INTEGER := -150; DECLARE total_2 CONSTANT INTEGER := 50;
DECLARE productPrice3 CONSTANT INTEGER := 150; DECLARE expense_amount_4 CONSTANT INTEGER := -50;
Диаграмма состояний сканера
Диаграмма состояний сканера

Тестовые примеры
Тест №1. Пример, показывающий все возможные лексемы, которые могут быть найдены лексическим анализатором.

Тест 1

Тест №2. Сложный пример.

При нажатии на лексему в таблице, соответствующий фрагмент текста подсвечивается в поле редактирования.

Тест 2

Тест №3. Сложный пример.

При нажатии на лексему в таблице, соответствующий фрагмент текста подсвечивается в поле редактирования.

Тест 3
