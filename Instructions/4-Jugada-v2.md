# Jugada v2

Modificaremos los test y la implementación de Bajara para aplicar las reglas reales del Poker.

Cuando termina la partida los jugadores compararán sus cartas, siguiendo las siguientes normal el que tenga la mano más fuerte gana, las reglas van de menos a más fuertes, por lo que el jugador con carta alta siempre perderá contra una escalera real.

- Carta más alta (Jugada menos fuerte)
Ya hemos implementado esta regla en la versión v1 por lo que no hace falta reimplementarlo. El jugador con la carta más alta gana, si se empata se mirará la carta secundaria más alta.

- Pareja
El jugador consigue tener dos parejas con el mismo valor, sin importar el palo.
En la mesa: KC, 3C, 4D, JS, 9H
Jugador 1: KH, 5C

Jugador 1 tiene pareja de reyes.

- Doble pareja
Dos parejas en la misma mano, si hay empate en la primera pareja se mira en la segunda más alta.

- Trio
El jugador consigue tener dos parejas con el mismo valor, sin importar el palo.
En la mesa: KC, KD, 4D, JS, 9H
Jugador 1: KH, 5C

Jugador 1 tiene trio de reyes.

- Straight
5 cartas de valores consecutivos. 
Los ases pueden estar al principio o al final, nunca en medio.
A -> 2 -> 3 -> 4 -> 5 GOOD
K -> A -> 2 -> 3 -> 4 BAD

La carta más alta marcará la escalera ganadora, el As es la mejor carta tanto en el principio como en el final de la escalera.

- Flush
5 cartas del mismo palo sin importar su valor, el flush con la carta más alta gana a otro flush.

- Full
Una pareja y un trio.

El trio con la carta más alta gana a el otro trio, en el caso de empate se mira la pareja.

En la mesa: KC, KD, 5S, JS, 9H
Jugador 1: KH, 5C

El jugador 1 tiene un full de K y 5.

- Cuatro iguales
Tener 4 del mismo valor.

La carta más alta gana en caso de que los dos jugadores tengan cuatro iguales.

En la mesa: KC, KD, KS, JS, 9H
Jugador 1: KH, 5C

El jugador 1 tiene cuatro K.

- Escalera de color
Una escalera donde todas las cartas son del mismo palo.
Los ases pueden estar al principio o al final, nunca en medio.

La carta más alta decide que escalera vale más.

- Escalera real (Jugada más fuerte)
Una escalera donde todas las cartas son del mismo palo y empieza por el 10 y termina por el A.

10H -> JH -> QH -> KH -> AH
