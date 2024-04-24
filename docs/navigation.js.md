Este código JavaScript se utiliza para agregar funcionalidades de navegación y enlace a GitHub en una página web, específicamente para un sitio de integración de GeoGebra. A continuación, se documenta cada parte del código:

### Función `addGithubLink()`

Esta función agrega un enlace a GitHub en la parte superior de la página, permitiendo a los usuarios ver el archivo actual en el repositorio de GitHub.

- **Variables:**
- `filename`: Obtiene el nombre del archivo actual de la URL. Si no hay un archivo especificado, se asume que es `index.html`.
- `menu`: Contiene el HTML para el enlace de GitHub, incluyendo un icono de menú y el nombre del sitio.
- `menuDiv`: Un elemento `div` que se crea para contener el menú.

- **Proceso:**
  1. Se crea un elemento `div` con la clase `sample-toolbar`.
  2. Se establece el `innerHTML` de `menuDiv` con el contenido de `menu`.
  3. Se inserta `menuDiv` al principio del cuerpo del documento.

### Función `addDrawer()`

Esta función agrega un menú lateral (drawer) a la página, que contiene enlaces a diferentes secciones del sitio.

- **Variables:**
- `filename`: Similar a `addGithubLink()`, obtiene el nombre del archivo actual.
- `menu`: Contiene el HTML para el menú lateral, incluyendo varias secciones y enlaces.
- `menuDiv`: Un elemento `div` que se crea para contener el menú lateral.

- **Proceso:**
  1. Se crea un elemento `div` con el ID `drawer` y se establece su `innerHTML` con el contenido de `menu`.
  2. Se inserta `menuDiv` después del primer hijo del cuerpo del documento.
  3. Se agrega un evento de clic al botón de menú para mostrar u ocultar el menú lateral.

### Función `loadNav()`

Esta función se encarga de cargar las funcionalidades de navegación y enlace a GitHub, dependiendo de si la página se está cargando en un marco o no.

- **Proceso:**
  1. Se inserta el estilo de Material Icons.
  2. Si la URL contiene el parámetro `frameless`, se agrega una clase al `contentBox` para ajustar su tamaño.
  3. De lo contrario, se llaman a `addGithubLink()` y `addDrawer()` para agregar las funcionalidades de navegación.

### Función `insertStyle(url)`

Esta función inserta una hoja de estilo en el documento.

- **Parámetros:**
- `url`: La URL de la hoja de estilo a insertar.

- **Proceso:**
  1. Se crea un elemento `link` y se establecen sus atributos para apuntar a la hoja de estilo.
  2. Se agrega el elemento `link` al `head` del documento.

### Inserción de Estilo y Evento de Carga

- Se inserta el estilo `navigation.css` utilizando `insertStyle()`.
- Se agrega un evento de carga al documento para llamar a `loadNav()` cuando la página se carga completamente.

Este código es un ejemplo de cómo se puede manipular el DOM y agregar funcionalidades dinámicas a una página web utilizando JavaScript.
