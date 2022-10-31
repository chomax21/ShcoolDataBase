# ShcoolDataBase - база данных Школы.
Замысел прост. База данных для школы. Для хранения и систематизации данных , по возможности вывода в MS OFFICE инструменты. Первое полноценное приложение. Практика. 
Данное приложение нигде в реальной жизни не используется, создавалось ради учебы, и получения практических знаний. Однако проводились консультации с работником школы, чтобы понять, что и где нужно.

Участие в разработке программы принимал - владелец репозитория. Мне (ему) - помогали YouTube, Metanit, Yandex, Google.

Проект построен на базе WinForms.

.NetCore 3.1 - понимание, что выбор для WinForms неудачный, т.к. .NetCore считается кроссплатформенным решением, а WinForms кроме как на Windows нигде не запускается пришло позже. Но не остановило от дальнейшей разработки. Цель научится работать с EntityFrameworkCore.

SQLite - выбрана в силу своих приимуществ в данном проекте, не нуждается в сервере бд. Сам файл бд хранится в папке приложения.

EntityFramework Core 5.0 - ORM. Инструмент в качестве удобной работы с базой данных. Проецирует сущности бд в програмные объекты и наоборот.

---

## Краткое описание возможностей программы.

### 1. Нас встречает окно авторизации.
При самом первом запуске приложения инициализируется бд с начальными данными. А именно логин и пароль Администратора. Он единственный доступный пользователь.
Далее пароль и логин можно заменить, или даже нужно.

LOGIN - admin, PASSWORD - admin.

![Снимок экрана 2022-10-28 212619](https://user-images.githubusercontent.com/84070601/198708004-ab52ea3d-13aa-43fe-bcc5-8961c40dddc1.png)

Реализована функция скрытия пароля.

### 2. Далее нас встречает основное окно приложения.

При загрузке сразу происходит подсчет учеников и учителей в системе и выводится их количество.


![Снимок экрана 2022-10-28 214629](https://user-images.githubusercontent.com/84070601/198710942-13c50233-ff41-442a-aefc-3d195cfc5750.png)


### 3. Работа с базой данных ученики.
Является основным окном с работой с учениками. Тут добавляются, редактируются, удаляются ученики. Их оценки. 

![image](https://user-images.githubusercontent.com/84070601/198710807-154b19d5-0115-4b3d-acfe-49d27703798a.png)

Кнопка EXCEL - выводит всю информацию отображенную в таблице в файл excel. Если Excel не установлени выводится обработанная ошибка.

Кнопка WORD - выводит конкретно вбыранную строку в word файл.

Кнопака Доп возможности скрывает за собой функционал переноса учеников в архив, и перевод всей школы на один учебный год вперед. Т.е. делается i++ значению класса.

![image](https://user-images.githubusercontent.com/84070601/198713983-75cc778e-de89-45fd-9f3b-b23eb1d3ed08.png)

Архив - логично ведет в окно архива.

Функция "Возраст +" производит подсчет возраста отображенных учеников от заданной даты, т.е. можно узнать сколько им будет полных лет на конкретную дату.

Двойное нажатие мышкой по записи в таблице открывает окно оценок учеников. Об этой форме далее.

### 4. Работа с базой данных сотрудники.
Основное окно для работы с сотрудниками школы. В целом похоже на предыдущее. 

![image](https://user-images.githubusercontent.com/84070601/199003029-4a494536-dbe9-4000-bad7-2201877b2678.png)

### 5. Общая информация ученики.
Окно раскрывает более доступную, быструю и уже отсортированную информацаю по некоторым шаблонам.
Можно выбрать любой интересующий вас класс, и получить детальную информацию. 

Сразу происходи подсчет по всем кретериям и категориям учеников. Предоствляются ссылки при нажатии на которые выводятся те ученики, которые находятся в конкретной категории.

При заполнии Главной таблицы учеников, ученики помеченные как староста будут отображаться тут для их быстрого поиска. Так же и классные руководители.

Отдельно по кнопке "Карточка ученика" можно получить более детальную информацию о ученике, и если нужно вывести ее на WORD файл.

![image](https://user-images.githubusercontent.com/84070601/199004636-b728fdf4-73b4-49b8-90f1-363e17e83d30.png)

![image](https://user-images.githubusercontent.com/84070601/199005028-72fef55c-b965-4269-82c4-c388d537b492.png)

### 6. Истечение срока повышения квалификации.
Окно служит для вывода сотрудников, время которых подходит для переподготовки или обновления соответсвующих знаний.

Т.е. здесь мы можем сразу понять, кому и когда следует заняться профподготовкой.

В самом окне мы можем выставить остаточное количество дней оставшихся до конца выхода "сертификатов".

![image](https://user-images.githubusercontent.com/84070601/199007084-d3d1ba8b-b58b-4bda-bd9b-bbbde60b05a0.png)

### 7. Курсы сотрудников.
Здесь мы вводим и редактируем курсы переподготовки сотрудников.

Попасть сюда можно из форму "База данных сотрудики" см. пункт 4. Нужно выбрать конкретного сотрудника и нажать на кнопку "Курсы"

![image](https://user-images.githubusercontent.com/84070601/199007687-976325a3-ad4a-426c-ad86-f4691ba6fcc7.png)












