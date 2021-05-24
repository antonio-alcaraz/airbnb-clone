# Jugada v1

Craremos la clase jugada con las reglas del Poker simplificadas.

Una jugada representa el final de una partida de Poker.

En la mesa habrá 5 cartas y cada jugador tendrá 2 cartas.

Un jugador combinará sus propias cartas con la mesa, el jugador con la mano más fuerte ganará esta ronda.

- Todos los palos valen lo mismo.
- El jugador con la carta más alta gana.
Ejemplo:
En la mesa: 2C, 2D, 4D, JS, 9H
Jugador 1: AC, 3C
Jugador 2: KC, QC

Ganador: Jugador 1 por tener la carta más alta AC.

- Si los dos jugadores tienen la misma carta más alta se mirará la segunda carta de estos para desempatar.
En la mesa: 2C, 2D, 4D, JS, 9H
Jugador 1: AC, 3C
Jugador 2: AD, QC
Ganador jugador 2 por tener por tener la segunda carta más alta QC.

Ejemplo:

- Si tienen las mismas cartas habrá un empate.
Ejemplo:
En la mesa: AC, 2D, 4D, JS, 9H
Jugador 1: 3C, 4C
Jugador 2: 3S, 4S