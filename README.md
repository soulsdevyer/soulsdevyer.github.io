# MecaLearn

MecaLearn es una plataforma interactiva de aprendizaje que conecta a estudiantes con el mundo de la ingeniería y la física a través de módulos educativos dinámicos e integraciones tecnológicas como IoT y simulaciones de GeoGebra. Su objetivo es desarrollar habilidades críticas y prácticas para enfrentar problemas actuales mediante soluciones tecnológicas.

## Tabla de Contenidos

1. [Acerca de MecaLearn](#acerca-de-mecalearn)
2. [Características](#características)
3. [Instalación](#instalación)
4. [Uso](#uso)
5. [Contribución](#contribución)
6. [Estructura del Proyecto](#estructura-del-proyecto)
7. [Guía de Estilo](#guía-de-estilo)
8. [Actualizaciones](#actualizaciones)
9. [Licencia](#licencia)

## Acerca de MecaLearn

MecaLearn es una plataforma e-learning diseñada para fomentar el aprendizaje autónomo en áreas de STEM, específicamente en temas de ingeniería y física. Está desarrollada con **Astro 4** y soporta simulaciones interactivas, experimentos con sensores como el DHT11, y la comunicación mediante Bluetooth con módulos Arduino. Nuestro objetivo es hacer el aprendizaje accesible, práctico y, sobre todo, ¡divertido!

## Características

- **Integración de simulaciones**: Soporte de GeoGebra y módulos interactivos.
- **Compatible con IoT**: Conexión con sensores y módulos como DHT11 y HC-05 para experimentos prácticos.
- **Aprendizaje visual y modular**: Diseño adaptable e inspirador con un enfoque en interfaces amigables como KhanAcademy.
- **Temas detallados**: Contenido educativo exhaustivo en temas como Termodinámica, Mecánica y más.
- **Interfaz amigable**: Inspirada en plataformas como Platzi, pero con un toque único de MecaLearn.

## Instalación

Para instalar y ejecutar MecaLearn en tu máquina local, sigue estos pasos:

1. **Clona el repositorio**:
   ```bash
   git clone https://github.com/tu_usuario/mecalearn.git
   cd mecalearn
   Instala dependencias: MecaLearn utiliza Astro y depende de algunas librerías como Tailwind CSS y TypeScript. Asegúrate de tener Node.js instalado y luego ejecuta:
   ```

bash
Copy code
npm install
Ejecuta el servidor local:

bash
Copy code
npm run dev
El sitio estará disponible en http://localhost:3000.

Uso
MecaLearn ofrece módulos de aprendizaje interactivos en un entorno educativo basado en navegadores. Puedes navegar a través de los diferentes temas, realizar simulaciones y conectar dispositivos IoT.

Explora los módulos: Accede a temas como Termodinámica, Dinámica, etc.
Prueba los experimentos: Si tienes un Arduino, conecta el módulo DHT11 para realizar experimentos.
Personaliza tu aprendizaje: Puedes modificar ciertos parámetros en los experimentos para adaptarlos a tus necesidades.
Contribución
¡Estamos encantados de recibir contribuciones! Para contribuir, sigue los siguientes pasos:

Forkea el repositorio y crea tu rama de trabajo.

bash
Copy code
git checkout -b feature/nueva-funcionalidad
Realiza tus cambios y asegúrate de seguir nuestra Guía de Estilo.

Realiza un pull request (PR): Describe los cambios que has hecho y por qué consideras que deben incluirse en MecaLearn.

Directrices para Contribuir
Escribe código claro y documentado.
Sigue los nombres en inglés para las constantes y variables.
Mantén el estilo de código consistente con los estándares de Tailwind y las prácticas de MecaLearn.
Utiliza TypeScript para mantener la tipificación en el código.
Estructura del Proyecto

Este es un esquema general de los directorios del proyecto:

mecalearn/
├── public/ # Archivos públicos
├── src/
│ ├── components/ # Componentes de UI reutilizables
│ ├── layouts/ # Estructuras de layout
│ ├── pages/ # Páginas de la aplicación
│ ├── styles/ # Archivos CSS y Tailwind
│ └── utils/ # Utilidades y funciones auxiliares
├── package.json # Dependencias y scripts de npm
└── README.md # Documentación principal

Guía de Estilo
Para asegurar la consistencia en todo el código, MecaLearn sigue ciertas pautas de estilo:

Colores: Usa los colores definidos en tailwind.config.mjs, por ejemplo meca-mainBlue.
Tipografía: Usa Inter para títulos y Poppins para el cuerpo.
Comentarios en TypeScript: Documenta las funciones y componentes con comentarios claros y concisos.
