# Práctica 04 - Sistemas de Interacción (SI)

## Eventos
En esta práctica usaremos eventos para generar distintos escenarios.

## Pelotas verdes y rojas
En este escenario se crean **5 esferas rojas** y **5 esferas verdes**, además de **un cubo** y **un cilindro**.  
El cilindro será el encargado de **generar el evento** (mediante el script `Event`), mientras que las esferas se **suscriben a dicho evento** (con el script `Subcripcion`).

El cilindro, además, funciona como un **trigger** que reacciona al ser golpeado por el cubo (que actúa como nuestro personaje principal, o **PJ**).  
Cuando se produce este evento, las **pelotas rojas** se dirigen hacia la posición de una de las **pelotas verdes**, y las **pelotas verdes** se desplazan hacia el **cilindro**.

![gif1](./videos%20escenarios/Practica4-ejer1.gif)
