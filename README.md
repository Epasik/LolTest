[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=Epasik_LolTest&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=Epasik_LolTest)

# Описание функций программы
### Функция public void DrawField(char[,] mazepol, player igrok):
Данная функция перемещает иконку игрока по лабиринту.

Входное значение:
char[,] mazepol - поле

player igrok - экземпляр класса player

### Функция protected void movementPlayer(ConsoleKey val, char[,] mazepol, player igrok):
Данная функция меняет координаты позиций игрока при нажатий пользователя на клавиши управления игроком и проверяет не дошел ли он до победной ячейки.

Входное значение:

ConsoleKey val - значение нажатой клавиши

char[,] mazepol - поле

player igrok - экземпляр класса player

### Функция static void Congratulations():
Данная функция выводит пользователю информацию о том что он прошел лабиринт и завершает программу.

### Функция void Update():
Данная функция срабатывает при нажатий пользователем на кнопку клавиатуры, считывает значение нажатой клавиши и передает его в функцию 

movementPlayer(ConsoleKey val, char[,] mazepol, player igrok) и после выхода из этой функции вызывает функцию DrawField() для отрисовки.

### Функция protected cellString getNeighbours(char[,] maze, Cell c):
Данная функция возвращает список доступных соседей переданной ячейки для дальнейшей генерации лабиринта.

Входные значения:

char [,] maze - поле.

Cell c - ячейка, для которой нужно найти соседей.

### Функция public int unvisitedCount(char[,] maze):

Данная функция возвращает количество непосещенных ячеек.

Входное значение:

char[,] maze - поле.


### Функция protected int removeWall(Cell first, Cell second, char[,] maze):

Данная функция удаляет стенку между поданных на вход ячеек. Возвращает 0 в случае удачи и -1 в случае неудачи.

Входные значения:

Cell first - первая ячейка

Cell second - вторая ячейка

char[,] maze - поле


### Функция void generate_step(char[,] mazepol):

Данная функция генерирует шаг построения случайного лабиринта, она обращается к функциям int unvisitedCount(char[,] maze), cellString getNeighbours(char[,] 
maze, cell c), int removeWall(cell first, cell second,char[] maze).

Алгоритм функции:
1) Задается изначальная ячейка
Пока есть непосещенные ячейки
    1) Производится поиск соседей текущей ячейки
    2) Случайным образом выбирается соседняя ячейка
    3) Удаляется стенка между этими ячейками
    
Входные значения:

char[,] mazepol - поле

### Функция public void init(int width, int height, char[,] mazepol):

Данная функция инициализирует изначальное поле.

Входные значения:

int width - ширина поля

int height - высота поля

char[,] mazepol - поле


### Функция public void init_start_player_pos():

Данная функция инициализирует старторвую позицию для игрока.

### Функция static void check_win():

Проверяет значение переменной win.

# Модульное тестирование
##### Тест public void init(Позитивный):

Описание: Проверка инициализации стартового поля

Функция:

initMaze()

Входные данные:

char [,]mazeTrue  - правильный массив для проверки

Ожидаемый результат:

Массивы идентичны - true



##### Тест test_removeWall(Позитивный):

Описание: Проверка удаления стенки

Функция:

removeWall()

Входные данные:

char[,] maze  - массив для проверки

firstcell - первая ячейка

secondcell - вторая ячейка

Ожидаемый результат:

Стенка удалена

##### Тест test_getNeighbours(Позитивный):
Описание: Проверка поиска и получения соседних ячеек

Функция:

getNeighbours()

Входные данные:

char[,] maze  - массив для проверки

firstCell - ячейка для поиска соседей

test - структура нескольких ячеек

test1.cells[0] = {1,3} - соседняя ячейка 

test1.cells[1] = {3,1} - соседняя ячейка

Ожидаемый результат:

Функция вернет соседние ячейки


##### Тест MoveW(Позитивный):

Описание: Проверка перемещения игрока при нажатий на клавишу "W"

Функция:

movementPlayer(ConsoleKey.W, test_mazepol, test_igrok)

Входные данные:

char[,] maze - поле

key - значение W

TestPlayer - экземпляр класса player

igrok.current_player_pos = {2,2} - позиция игрока 

Ожидаемый результат:

Игрок переместится в ячейку {1,2}



##### Тест MoveD(Позитивный):

Описание: Проверка перемещения игрока при нажатий на клавишу "D"

Функция:

movementPlayer(key, maze, TestPlayer)

Входные данные:

char[,] maze - поле

key - значение D


TestPlayer - экземпляр класса player

igrok.current_player_pos = {2,2} - позиция игрока 

Ожидаемый результат:

Игрок переместится в ячейку {2,3}


##### Тест MoveS(Позитивный):

Описание: Проверка перемещения игрока при нажатий на клавишу "S"


Функция:

movementPlayer(key, test_mazepol, test_igrok)

Входные данные:

char[,] maze - поле

key - значение S

test_igrok - экземпляр класса player

igrok.current_player_pos = {2,2} - позиция игрока 

Ожидаемый результат:

Игрок переместится в ячейку {3,2}



##### Тест MoveA(Позитивный):

Описание: Проверка перемещения игрока при нажатий на клавишу "A"

Функция:

movementPlayer(key, test_mazepol, test_igrok)

Входные данные:

char[,] test_mazepol - поле

key - значение A

test_igrok - экземпляр класса player

test_igrok.current_player_pos = {2,2} - позиция игрока 

Ожидаемый результат:

Игрок переместится в ячейку {2,1}



##### Тест removeWall(Негативный):

Описание: Проверка на выход за границы массива при удалении стенки

Функция:

removeWall(firstCell, secondCell, maze)

Входные данные:

char[,] maze  - массив для проверки

FirstCell[11,1] - первая ячейка

SecondCell[1,3] - вторая ячейка

Ожидаемый результат:

removeWall() вернет -1



##### Тест initMaze(Негативный):

Описание: Проверка инициализации стартового поля

Функция:

initMaze()

Входные данные:

char[,] mazeTrue  - неправильный массив для проверки

Ожидаемый результат:

Массивы не идентичны - false



##### Тест testNegative_GetNeighbours(Негативный):

Описание: Проверка поиска и получения соседних ячеек при их отсутсвии

Функция:

getNeighbours(maze, firstCell)

Входные данные:

maze  - массив для проверки, где у ячейки {1,1} нет соседей

firstCell - ячейка для поиска соседей

Ожидаемый результат:

getNeighbours() вернет пустой массив



##### Тест NegativeMovementW(Негативный):

Описание: Проверка перемещения игрока при нажатий на клавишу "W", когда там находится стена

Функция:

movementPlayer()

Входные данные:

char[,] test_mazepol - поле

key - значение A

test_igrok - экземпляр класса player

test_igrok.current_player_pos = {1,1} - позиция игрока 

Ожидаемый результат:

Игрок останется в той же ячейке



##### Тест NegativeMovemenD(Негативный):

Описание: Проверка перемещения игрока при нажатий на клавишу "D", когда там находится стена

Функция:

movementPlayer()

Входные данные:

char[,] test_mazepol - поле

key - значение A

test_igrok - экземпляр класса player

test_igrok.current_player_pos = {1,13} - позиция игрока 

Ожидаемый результат:

Игрок останется в той же ячейке



##### Тест NegativeMovemenS(Негативный):

Описание: Проверка перемещения игрока при нажатий на клавишу "S", когда там находится стена

Функция:

movementPlayer()

Входные данные:

char[,] test_mazepol - поле

key - значение A

test_igrok - экземпляр класса player

test_igrok.current_player_pos = {13,1} - позиция игрока 

Ожидаемый результат:

Игрок останется в той же ячейке



##### Тест NegativeMovementA(Позитивный):

Описание: Проверка перемещения игрока при нажатий на клавишу "A"

Функция:

movementPlayer()

Входные данные:

char[,] test_mazepol - поле

key - значение A

test_igrok - экземпляр класса player

test_igrok.current_player_pos = {1,1} - позиция игрока 

Ожидаемый результат:

Игрок останется в той же ячейке



# Интеграционное тестирование

##### Тест test_GenerateStep(Позитивный):

Описание: Проверка генерации шага построения лабиринта

Функция:

generateStep(maze)

Входные данные:

maze - поле

Ожидаемый результат:

Существует проход между ячейками {1,1} - {1,3} или между ячейками {1,1} - {3,1}
















