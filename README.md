# Описание решения задачи
1. Задаем исходный массив.
2. Выделяем место под новый массив такого же размера, что и исходный.
3. Вводим переменные count и i для индекса элементов нового и исходного массива, задаем им первоначальное значение равное 0.
4. Вводим цикл (пока i меньше размера массива, i увеличиваем на 1) для перебора каждого элемента массива.
5. Внутри цикла вводим условие, размер элемента с индексом i меньше либо равно 3 символа.
6. Если условие выполняется, элементу нового массива с индексом count присваивается значение элемента исходного массива с индексом i, и count увеличивается на 1.
7. После завершения цикла, выводим новый массив.
