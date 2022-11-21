# TestDtoView

1. Используем NewtonsoftJson.
2. Все поля в Dto - virtual, { get; init; }. Классы не запечатаны.
3. Все поля в View - { get; init; }. Классы запечатаны(кроме родительских).
4. Конструкторы не создаём, используем только конструкторы по умолчанию.
5. Экземпляры Dto в тестах создаём через Mock(поэтому Dto не запечатываем и поля - virtual).
