## Práctica Fisicas en Unity

* Autor : Alien Embarec Riadi

* Fecha Comienzo : Sesión Viernes 18 de octubre

En esta práctica se ha trabajado con propiedades físicas en *GameObjects*, estas propiedades en Unity, se concentran en el *Component* denominado RigidBody.


<p align="justify">

La escena cuenta con un terreno texturizado, donde una parte de él adquiere forma de relieve. Tiene un personaje, *Ethan*, de la Standard Assets, sobre el que aplicaremos *RigidBody*, implementaremos código para hacer movimientos físicos (Véase *EthanMovement.cs*), un contador de colisiones con la esfera. El movimiento físico se consigue con el método *AddForce*, pasándole las coordenadas del movimiento que queremos hacer, y la aceleración. Un cubo, *GameObject*, sobre el que implementaremos código para moverlo físicamente con las teclas ILJM, con JL nos movemos hacia delante o atrás respectivamente, IM, para movernos hacia izquierdas o derecha, siempre tomando como sistema de referencia la cámara.
</p>
<p align="justify">
	
También cuenta con una cápsula, *GameObject* ( código en el fichero *CapsuleMovement.cs*), que también moveremos con las teclas ILJM. Dos esferas, *GameObject*, una se mueve aleatoriamente (Véase *RandomMovementScript.cs*) por el terreno ( véase *RandomMovement.cs*), y la otra es movida por *Ethan*.

</p>
<p align="justify">

En cuanto a cámaras, cuenta con tres , una cámara para seguir el movimiento de *Ethan*, y las otras dos, una para la cápsula, y la otra para el cubo, como estos últimos dos objetos realizan movimientos en los tres ejes, para que la cámara no varíe sus coordenadas en los tres ejes, y se mantenga a una distancia para que el ojo humano pueda ver el movimiento del objeto, se les aplica el script que viene en Unity *FollowTarget*, este script se configura en el *Inspector* de la cámara para que esté a una cierta distancia del GameObject, y solo se mueva en los ejes *xz*, que representan movimiento horizontal y en profundidad.


</p>
<p align="justify">

También hay un objeto inmóvil, el cilindro, el cilindro es un RigidBody, pero además con  la propiedad *Is Kinematic* activada, esto significa que no reacciona a las colisiones de otros objetos, lo que se ha implementado es un script con sensores que le hacen cambiar a un color diferente según el objeto chocante sea *Ethan*, la esfera, el cubo o la cápsula (estas últimas dos el cilindro cambia al mismo color). Asimismo, el color del cilindro  varía de intensidad según el objeto acabe de colisionar, siga chocándose, o salga de la colisión. (Véase el fichero *CylinderSensors.cs*).

</p>
<p align="justify">

Para la  colisión del personaje, se ha escogido el color rojo, la esfera modifica el cilindro a azul, mientras que la cápsula y el cubo lo hacen a verde.

</p>



Se puede visionar en los GIF la acción de los elementos citados anteriormente.

![Alt Text](./img/CharacterMovementsAndCollisions.gif)

![Alt Text](./img/CubeMovementsAndCollisions.gif)