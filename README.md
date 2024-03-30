<!DOCTYPE html>
<html>
<body>
  <h1>Компилятор</h1>
  <p>Разработка текстового редактора с функциями языкового процессора.</p>

  <h2>Оглавление</h2>
  <ul>
    <li><a href="#lab1">Лабораторная работа №1: Разработка пользовательского интерфейса (GUI) для языкового процессора</a></li>
    <li><a href="#lab2">Лабораторная работа №2: Разработка лексического анализатора (сканера)</a></li>
    <li><a href="#lab3">Лабораторная работа №3: Разработка синтаксического анализатора (парсера)</a></li>
    <li><a href="#lab4">Лабораторная работа №4: Нейтрализация ошибок (метод Айронса)</a></li>
    <li><a href="#lab5">Лабораторная работа №5: Включение семантики в анализатор. Создание внутренней формы представления программы</a></li>
    <li><a href="#lab6">Лабораторная работа №6: Реализация алгоритма поиска подстрок с помощью регулярных выражений</a></li>
    <li><a href="#lab7">Лабораторная работа №7: Реализация метода рекурсивного спуска для синтаксического анализа</a></li>
  </ul>

  <h2 id="lab1">Лабораторная работа №1: Разработка пользовательского интерфейса (GUI) для языкового процессора</h2>
  <p>Тема: разработка текстового редактора с возможностью дальнейшего расширения функционала до языкового процессора.</p>

  <p>Цель работы: разработать приложение с графическим интерфейсом пользователя, способное редактировать текстовые данные. Это приложение будет базой для будущего расширения функционала в виде языкового процессора.</p>

  <p>Язык реализации: C#, WPF.</p>

  <h3>Интерфейс текстового редактора</h3>
  <p>Главное окно программы</p>
  <img src="bin/Debug/net7.0-windows/Readme/Example.jpg" alt="Рабочее окно текстового редактора с обозначенными элементами.">
  
  <h3>Получившийся текстовый редактор имеет следующие элементы:</h3>
  <ol>
    <li value="1">Заголовок окна.</li>  
    <p>Содержит информацию о названии открытого файла, полного пути к нему, а также о том, сохранен ли он на текущий момент (наличие символа звездочки справа от названия означает наличие несохраненных изменений).</p>
    <li value="2">Меню.</li>  
    <table>
      <tr>
        <th>Пункт меню</th>
        <th>Подпункты</th>
      </tr>
      <tr>
        <td>Файл</td>
        <td><img src="bin/Debug/net7.0-windows/Readme/File.png" alt="File"></td>
      </tr>
      <tr>
        <td>Правка</td>
        <td><img src="bin/Debug/net7.0-windows/Readme/Edit.png" alt="Edit"></td>
      </tr>
      <tr>
        <td>Текст</td>
        <td><img src="bin/Debug/net7.0-windows/Readme/Text.png" alt="Text"></td>
      </tr>
      <tr>
        <td>Пуск</td>
        <td>Отсутствует</td>
      </tr>
      <tr>
        <td>Справка</td>
        <td><img src="bin/Debug/net7.0-windows/Readme/Reference.png" alt="Reference"></td>
      </tr>
    </table>
    <li value="3">Панель инструментов</li>
	<img src="bin/Debug/net7.0-windows/Readme/Toolbar.png" alt="Toolbar">
      <ul>
        <li>Создать</li>
        <li>Открыть</li>
        <li>Сохранить</li>
        <li>Отменить</li>
        <li>Повторить</li>
        <li>Пуск</li>
        <li>Копировать</li>
        <li>Вырезать</li>
        <li>Вставить</li>
        <li>Изменить размер текста</li>
      </ul>
    <li value="4">Область редактирования</li>
    <p>Поддерживаются следующие функции:</p>
      <ul>
        <li>Изменение размера текста</li>
        <li>Открытие файла при перетаскивании его в окно программы</li>
      </ul>
    <li value="5">Область отображения результатов</li>
    <p>В область отображения результатов выводятся сообщения и результаты работы языкового процессора.</p>
    <p>Поддерживаются следующие функции:</p>
      <ul>
        <li>Изменение размера текста</li>
        <li>Отображение ошибок в виде таблицы</li>
      </ul>
  </ol>
    <h3>Справочная система</h3>
    <p>Разделы справочной системы открываются как HTML-документы в браузере.</p>
    <table>
      <tr>
        <th>Раздел</th>
        <th>Изображение</th>
      </tr>
      <tr>
        <td>Вызов справки</td>
        <td><img src="bin/Debug/net7.0-windows/Readme/Information.png" alt="Information"></td>
      </tr>
      <tr>
        <td>О программе</td>
        <td><img src="bin/Debug/net7.0-windows/Readme/About.png" alt="About"></td>
      </tr>
    </table>
    <h3>Вывод сообщений</h3>
    <table>
      <tr>
        <th>Сообщение</th>
        <th>Описание</th>
      </tr>
      <tr>
        <td>Закрытие окна программы</td>
        <td>Появляется при закрытии программы нажатием крестика или комбинацией клавиш при наличии несохраненных изменений</td>
      </tr>
      <tr>
        <td>Сохранение изменений</td>
        <td>Появляется при попытке открыть существующий файл или создать новый при наличии несохраненных изменений	Сохранение изменений</td>
      </tr>
    </table>
   
  <h2 id="lab2">Лабораторная работа №2: Разработка лексического анализатора (сканера)</h2>
  <p>Тема: разработка лексического анализатора (сканера).</p>

  <p>Цель работы: изучить назначение лексического анализатора. Спроектировать алгоритм и выполнить программную реализацию сканера.</p>
  
  <table>
    <tr>
      <th>№</th>
      <th>Тема</th>
      <th>Пример верной строки</th>
      <th>Справка</th>
    </tr>
    <tr>
      <td>3</td>
      <td>Объявление комплексного числа с инициализацией на языке Python</td>
      <td>z3 = complex(1, 2.5)</td>
      <td><a href="https://stepik.org/lesson/360942/step/11">Справка</a></td>
    </tr>
  </table>

  <h3>В соответствии с вариантом задания необходимо:</h3>
  <ol>
    <li>Спроектировать диаграмму состояний сканера.</li>
    <li>Разработать лексический анализатор, позволяющий выделить в тексте лексемы, иные символы считать недопустимыми (выводить ошибку).</li>
    <li>Встроить сканер в ранее разработанный интерфейс текстового редактора. Учесть, что текст для разбора может состоять из множества строк.</li>
  </ol>

  <p>Входные данные: строка (текст программного кода).</p>

  <p>Выходные данные: последовательность условных кодов, описывающих структуру разбираемого текста с указанием места положения и типа.</p>

  <h3>Примеры допустимых строк</h3>
  <pre>
    z2 = complex(6,8.3)
    z3 = complex(-1,2.5)
    z4 = complex(5,-2.8)
  </pre>

  <h3>Диаграмма состояний сканера</h3>
  <img src="bin/Debug/net7.0-windows/Readme/compile.png" alt="Диаграмма состояний сканера">

  <h3>Тестовые примеры</h3>
  <h4>Тест. Пример, показывающий все возможные лексемы, которые могут быть найдены лексическим анализатором.</h4>
  <img src="bin/Debug/net7.0-windows/Readme/Test.png" alt="Тест">

  <h2 id="lab3">Лабораторная работа №3: Разработка синтаксического анализатора (парсера)</h2>
  <p>Тема: разработка синтаксического анализатора (парсера).</p>

  <p>Цель работы: изучить назначение синтаксического анализатора, спроектировать алгоритм и выполнить программную реализацию парсера.</p>
  
  <table>
    <tr>
      <th>№</th>
      <th>Тема</th>
      <th>Пример верной строки</th>
      <th>Справка</th>
    </tr>
    <tr>
      <td>3</td>
      <td>Объявление комплексного числа с инициализацией на языке Python</td>
      <td>z3 = complex(1, 2.5)</td>
      <td><a href="https://stepik.org/lesson/360942/step/11">Справка</a></td>
    </tr>
  </table>

  <a href="#lab2">Примеры допустимых строк</a>

  <h3>В соответствии с вариантом задания на курсовую работу необходимо:</h3>
    <ol>
      <li>Разработать автоматную грамматику.</li>
      <li>Спроектировать граф конечного автомата (перейти от автоматной грамматики к конечному автомату).</li>
      <li>Выполнить программную реализацию алгоритма работы конечного автомата.</li>
      <li>Встроить разработанную программу в интерфейс текстового редактора, созданного на первой лабораторной работе.</li>
    </ol>

  <h3>Грамматика</h3>
    <pre>
      G[<КЧ> = <Комплексное_число>]: 
      VT = { ‘a’…’z’, ‘A’…’Z’, '=', 'complex', '(', ')', '+', 'j', '-', '0'...'9', '.', ‘_’, ‘'‘ }
      VN = { <КЧ>, COMPLEXREM, ASSIGNTMENT, OPEN, REALPART, INTREALPART, INTREALPARTREM, DECIMALREALPART, IMAGINARYPART, DECIMALREALPARTREM, INTIMAGINARYPART, INTIMAGINARYPARTREM, DECIMALIMAGINARYPART, DECIMALIMAGINARYPARTREM, CLOSE}
      P = {
	      <КЧ> -> letter COMPLEXREM
        COMPLEXREM -> (letter | _ | digit) COMPLEXREM | = ASSIGNTMENT
        ASSIGNTMENT -> complex OPEN 
        OPEN -> ( REALPART 
        REALPART -> [+ | -] INTREALPART 
        INTREALPART -> digit0 INTREALPARTREM 
        INTREALPARTREM -> digit INTREALPARTREM | . DECIMALREALPART | , IMAGINARYPART 
        DECIMALREALPART -> digit DECIMALREALPARTREM 
        DECIMALREALPARTREM -> digit DECIMALREALPARTREM | , IMAGINARYPART
        IMAGINARYPART -> [+ | -] INTIMAGINARYPART
        INTIMAGINARYPART -> digit0 INTIMAGINARYPARTREM
        INTIMAGINARYPARTREM -> digit INTIMAGINARYPARTREM | . DECIMALIMAGINARYPART
        DECIMALIMAGINARYPART -> digit DECIMALIMAGINARYPARTREM
        DECIMALIMAGINARYPARTREM -> digit DECIMALIMAGINARYPARTREM |  CLOSE 
        CLOSE -> )
        letter → ‘a’ | ‘b’ | … | ‘z’ | ‘A’ | ‘B’ | … | ‘Z’
        digit → ‘0’ | ‘1’ | … | ‘9’
        digit0 →  ‘1’ | … | ‘9’
      }
    </pre>

  <h3>Граф конечного автомата</h3>
  <img src="bin/Debug/net7.0-windows/Readme/Graph.png" alt="Граф конечного автомата">
  <h3>Тестовые примеры</h3>
  <h4>Тест №1. Все выражения написаны корректно.</h4>
  <img src="bin/Debug/net7.0-windows/Readme/Test1.png" alt="Тест1">
  <h4>Тест №2. Пример ошибок.</h4>
  <img src="bin/Debug/net7.0-windows/Readme/Test2.png" alt="Тест2">

  <h2 id="lab4">Лабораторная работа №4: Нейтрализация ошибок (метод Айронса)</h2>
  <p>Тема: нейтрализация ошибок (метод Айронса).</p>

  <p>Цель работы: реализовать алгоритм нейтрализации синтаксических ошибок и дополнить им программную реализацию парсера.</p>
  
  <h3>Граф конечного автомата</h3>
  
  <p>Разрабатываемый синтаксический анализатор построен на базе автоматной грамматики. При нахождении лексемы, которая не соответствует грамматике предлагается свести алгоритм нейтрализации к последовательному удалению следующего символа во входной цепочке до тех пор, пока следующий символ не окажется одним из допустимых в данный момент разбора.</p>
  
  <h3>Тестовые примеры</h3>
  <h4>Тест №1. Пример ошибок.</h4>
  <img src="" alt="Тест">

</body>
</html>
