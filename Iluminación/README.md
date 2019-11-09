
### Tarea Iluminación en Unity

* Autor : Alien Embarec Riadi

* Enlace de GitHub al repositorio de la tarea : https://github.com/Alien-97/Interfaces_Inteligentes/tree/master/Iluminaci%C3%B3n
* 1.) *Light mapping*

	Lightmapping es el proceso de pre-calcular el brillo de las superficies en una escena, y almacenar el resultado en un gráfico o "mapa de luz" para su uso posterior.

	Unity utiliza un sistema llamado Progressive Lightmapper, que crea mapas de luz para la escena según la configuración de la escena dentro de Unity, teniendo en cuenta las mallas, los materiales, las texturas y las luces. Lightmapping es una parte integral del motor de renderizado; cuando se crean los lightmaps, los GameObjects los usan automáticamente.

	Podemos personalizar el Light mapping en nuestro proyecto accediendo a Windows > Rendering > Lighting Settings.

	Debemos verificar que la malla a la que deseamos aplicar un light map tenga las coordenadas UV adecuadas para el mapeo de luz.


* 2.) *Bump mapping*

	El mapeado topológico (en inglés, bump mapping) es una técnica de gráficos computacionales 3D creada por James F. Blinn en 1978. Consiste en dar un aspecto rugoso a las superficies de los objetos. Esta técnica modifica las normales de la superficie sin cambiar su geometría. Las normales originales de la superficie seguirán perpendiculares a la misma. El mapeado topológico cambia la perpendicularidad por otras normales para lograr el efecto deseado, todo ello sin modificar la topología ni la geometría del objeto.

	Bump mapping es una técnica antigua pero de gran actualidad en el desarrollo de videojuegos, gracias al Normal mapping, que es un tipo de Bump map. Se explicará cómo integrarlo en el proyecto en el siguiente punto.

* 3.) *Normal mapping*

	Los Normal Maps son un tipo de Bump Mapping. Son un tipo especial de textura que permiten agregar detalles en las superficies como golpes/bultos/bumps, surcos, rayones a un modelo que atrapa la luz como si fuera representado por una geometría real.

	Podemos usar el normal mapping en nuestro proyecto selecionando esta propiedad en los materiales que creemos con Assets->Create->Material

	Una vez el Material haya sido creado, podemos aplicarlo a un objeto y ajustar todas su propiedades en el Inspector. 

	El Bump map se sigue utilizando, en los casos en los que no se quiere dar un acabado con mucha textura y formas, es muy eficiente.

* 4.) *Sky Box*

	Los Skyboxes son una envoltura alrededor de la escena entera que muestra cómo el mundo se vería más allá de su geometría.

	Podemos agregarlo  al crear un material en Assets->Create->Material. Seleccionamos el despegable del shader arriba del Inspector, escogemos Skybox/6 Sided.
	Creamos 6 texturas que corresponden a cada uno de los 6 lados del skybox y los colocamos en la carpeta Assets del proyecto.

	Para cada textura se necesita cambiar el modo de envuelto (wrap mode) de Repeat a Clamp. Si no se hace esto, los colores en los bordes no van a coincidir.

* 5.) Environment mapping

	El mapeado del entorno es una técnica eficiente de iluminación basada en imágenes para aproximar la apariencia de una superficie reflectante por medio de una imagen de textura precalculada. La textura se utiliza para almacenar la imagen del entorno distante que rodea al objeto renderizado.

	También conocidos como cubemaps en Unity, la manera más rápida de añadirlos es importándolos con texturas especialmente diseñadas. Seleccionamos la textura en el área del proyecto, accedemos  a los parámetros del área del Inspector. En los ajustes de importado (Import Settings), ponemos el Texture Type a default, Normal map o Single Channel, y el Texture Shape a Cube. Unity convertirá automáticamente la textura a Cubemap.
	
* 6.) Iluminación global

	Global Illumination (GI) es un sistema que modela cómo la luz rebota de superficies a otras superficies (luz indirecta) en vez de estar limitada a la luz que golpea una superficie directamente desde una fuente de luz (luz directa). Modelar la luz indirecta permite efectos que hacen que el mundo virtual se vea más real y conectado, ya que los objetos afectan la apariencia de cada uno.

	Unity usa por defecto este modelo para iluminar las escenas.


