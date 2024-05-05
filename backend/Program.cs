namespace ArduinoWebSocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new WebSocketServer(IPAddress.Any, 8080); // Port 8080
            server.AddWebSocketService<ArduinoWebSocket>("/arduino");
            server.Start();
          
            Console.WriteLine("WebSocket Server Started");

            Console.ReadLine();

            server.Stop();
        }
    }

    public class ArduinoWebSocket : WebSocketBehavior
    {
        SerialPort? serialPort;

        protected override void OnOpen()
        {
            // Open the serial port
            serialPort = new SerialPort("COM3", 9600); // Change "COM3" to your serial port
            serialPort.DataReceived += SerialPort_DataReceived;

            try
            {
                serialPort.Open();
                Console.WriteLine("Serial port opened");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening serial port: " + ex.Message);
            }
        }

        protected override void OnClose(CloseEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                Console.WriteLine("Serial port closed");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read data from serial port and send it to all connected clients
            var data = serialPort.ReadLine().Trim();
            var text = "Texto de prueba";
            Console.WriteLine("Data received from Arduino: " + data);
            Sessions.Broadcast(data);
            Sessions.Broadcast( text);

        }
    }
}
