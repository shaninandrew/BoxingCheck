# Boxing


Тест скорости работы с переменными в режиме объектов и явно указанного типа (int/string).

      Конфигурация: Intel(R) Core(TM) i5-4670 CPU @ 3.40GHz   3.40 GHz / 16 Гб

Вывод: скорость работы с object ~ сопоставима с работой со строками.

Результат работы программы (без отладки x64) _____________________________________________

      Проверка работы с массивом через боксинг (object[])...
         В коробке-style = 4,57 сек
      Сумма 13827251899520
   
      Проверка работы с целочисленным массивом без боксинга (int[])...
         Без коробки-style = 0,36 сек
      Сумма 13827251899520
   
    Проверка боксинга для строк (object[])...
         В коробке-style = 9,42 сек
   
    Проверка работы без боксинга для строк (string[])...
         Вне коробки-style (чистые строки) = 9,48 сек
