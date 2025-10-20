# Práctica 04 - Sistemas de Interacción (SI)

## Eventos
En esta práctica usaremos eventos para generar distintos escenarios.

## Pelotas verdes y rojas
En este escenario se crean **5 esferas rojas** y **5 esferas verdes**, además de **un cubo** y **un cilindro**.  
El cilindro será el encargado de **generar el evento** (mediante el script `Event`), mientras que las esferas se **suscriben a dicho evento** (con el script `Subcripcion`).

El cilindro, además, funciona como un **trigger** que reacciona al ser golpeado por el cubo (que actúa como nuestro personaje principal, o **PJ**).  
Cuando se produce este evento, las **pelotas rojas** se dirigen hacia la posición de una de las **pelotas verdes**, y las **pelotas verdes** se desplazan hacia el **cilindro**.

![gif1](./videos_escenarios/Practica4-ejer1.gif)

## Guerreros y Magos 
  Repetimos esl caso anteriro solo que aqui sustituimos a las pelotas por **magos** y **guerros** de los asset de la practica.

  ![gif2](./videos_escenarios/Practica4-ejer2.gif)

## Guerreros y magos 2

En este caso tenemos a los **magos**, que son NPC del **tipo 1**, y a los **guerreros**, que son NPC del **tipo 2**.  
Cuando nuestro personaje (el cubo) colisiona con alguno de los personajes del **tipo 2**, los NPC del **tipo 1** se dirigen hacia unos **escudos** previamente asignados y además **cambian de color**.  
Si el cubo colisiona con un NPC del **tipo 1**, ocurre lo mismo pero al revés: los personajes del **tipo 2** se mueven hacia sus escudos correspondientes y también **cambian de color**.

Estos eventos se gestionan a través de un **script global llamado `EventManager`**, que se encarga de **emitir mensajes** cuando se produce una colisión con un tipo u otro de NPC.  
Los NPC están suscritos a estos eventos mediante sus propios scripts, y reaccionan dependiendo de su tipo.

El script **`EventManager`** define dos eventos principales:

- **`OnMiTipo1ColisionConCubo`**: se activa cuando el cubo colisiona con un NPC de tipo 1.  
- **`OnMiTipo2ColisionConCubo`**: se activa cuando el cubo colisiona con un NPC de tipo 2.  

El script **`CubeDetector`** se encarga de **detectar las colisiones del cubo con los NPC** y **avisar al `EventManager`** para que dispare el evento correspondiente.

Cada NPC tiene un componente **`HumanoideTypeIdentifier`**, que determina si pertenece al **tipo 1** o al **tipo 2** según su etiqueta en el inspector (`tipo1` o `tipo2`).

Por último, el script **`HumanoideMover`** se encarga de **escuchar los eventos enviados por el `EventManager`** y de **mover al NPC hacia su escudo asignado** cuando corresponde.  
En este script, los NPC del **tipo 1** se mueven si se detecta una colisión con un **tipo 2**, y los NPC del **tipo 2** se mueven si la colisión fue con un **tipo 1**.  
El movimiento se realiza suavemente mediante una **corrutina** que los desplaza hacia la posición del escudo.

En conjunto, estos scripts permiten crear un **sistema de interacción** en el que los personajes reaccionan dinámicamente a las colisiones de nuestro personaje principal, gestionando la comunicación de eventos de forma global y ordenada.

![gif3](./videos_escenarios/Practica4-ejer3.gif)



