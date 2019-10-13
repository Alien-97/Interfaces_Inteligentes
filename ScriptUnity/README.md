##### Tarea Script Unity  Viernes 11 Octubre

* Autor: Alien Embarec Riadi



En esta tarea se ha creado un script en Unity para mover un objeto 3D, en este caso un cubo. Los movimientos eran básicos, derecha, izquierda, delante, atrás, en el eje *x* y el en eje *z*. Dichos movimientos adquieren un valor entre 0 y 1 cuando son positivos ( a derecha o hacia delante), y entre 0 y -1 cuando son negativos ( a izquierda o hacia atrás).

A modo de contexualización, el código de un script en Unity se divide  en dos funciones, una es *start*, que como su propio nombre indica se ejecuta una sola vez al inicio de la ejecución del juego, y otra es *update*, que se ejecuta en bucle frame por frame, y va captando los movimientos del objeto.


Para implementar estos movimientos nos hemos valido de la propiedad Transform del objeto 3D, con una variable que almacena el input, este Input es un listener que registra cuando pulsamos el teclado, en este caso las teclas *aswd*, a y d para moverse a la derecha, y ws para moverse  hacia delante o hacia atrás.

También se crea un campo público  para introducir que el usuario introduzca la velocidad a la que queremos que se mueva el cubo. Otra variable que se crea es *movement*, que es de tipo Vector3, y almacena las coordenadas que corresponden al movimiento que queremos realizar, por ejemplo, si queremos movernos a la derecha, como el movimiento es horizontal y positivo, la coordenada sería (1,0,0).

Cabe destacar que el sistema de referencia que se está considerando en Unity es aquel en el que la x representa el movimiento en el plano, a derecha o izquierda, la z representa la profundidad, es decir, los movimientos hacia delante o hacia atrás, y por último, la y, representa la altura, es decir, el movimiento hacia arriba o abajo.

Posteriormente usamos el tiempo físico y no el frame para calcular la distancia que nos movemos, a similitud de la fórmula física *espacio = velocidad * tiempo*, para obtener el tiempo usamos *Time.deltaTime*, para calcular el tiempo que pasó desde el anterior frame hasta el actual,  considerando una velocidad constante, para obtener la distancia exacta que se ha movido el objeto.



