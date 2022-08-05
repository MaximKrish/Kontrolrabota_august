# *Итоговая проверочная работа по курсу "Знакомство с языками программирования"*

## **Формулировка задачи**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## **Алгоритм программы**

ВВодим колличество элементов вручную, а также указываем колличество элементов которые будем искать в заполненном массиве :

1. *Заполняем наш массив числами либо символами.*

2. *Вычисляем количество строк, длинна которых меньше либо равна 3 символа  ( в нашем случае любое количество которое мы введем вручную).*
>В цикле проходим по каждой строке массива и заполняем массив вручную. На каждой итерации сверяем длину строки - если длина меньше или равна трём записываем результат в новый массив. 

3. *Выводим массивы первоначальный и тот что нашли  в консоль*



## *Примеры массивов и результаты выводов*
```
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
```