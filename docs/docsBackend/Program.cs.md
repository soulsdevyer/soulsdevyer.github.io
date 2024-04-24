# ArduinoWebSocketServer

Este programa C# establece un servidor WebSocket para comunicarse con un dispositivo Arduino.

## Funcionalidad

El servidor WebSocket espera conexiones de clientes y retransmite los datos recibidos desde el puerto serie del Arduino a todos los clientes conectados.

## Dependencias

El programa utiliza las siguientes bibliotecas:

- `System`: Proporciona acceso a las clases básicas del sistema y los tipos primitivos.
- `System.IO.Ports`: Permite la comunicación serial con el dispositivo Arduino.
- `System.Net`: Contiene clases para la comunicación de red, como IP y DNS.
- `WebSocketSharp`: Ofrece una implementación WebSocket para .NET.
- `WebSocketSharp.Server`: Proporciona funcionalidad para crear servidores WebSocket.

## Uso

1. El servidor se inicia en el puerto 8080.
2. Se agrega un servicio WebSocket para manejar las conexiones de clientes en la ruta "/arduino".
3. Cuando se abre una conexión, se abre el puerto serie especificado (por ejemplo, "COM3") a 9600 baudios.
4. Los datos recibidos del puerto serie se transmiten a todos los clientes conectados.
5. Cuando se cierra la conexión, se cierra el puerto serie.

## Ejecución

1. El servidor se inicia mediante la ejecución del método `Main` en la clase `Program`.
2. Se muestra un mensaje indicando que el servidor WebSocket ha comenzado.
3. El servidor sigue ejecutándose hasta que se presiona Enter en la consola.
4. Al presionar Enter, se detiene el servidor WebSocket.

## Notas

- Asegúrate de modificar el puerto COM (`"COM3"`) en la línea `serialPort = new SerialPort("COM3", 9600);` para que coincida con el puerto COM de tu dispositivo Arduino.
