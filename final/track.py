import socket
import time 

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
serverAddressPort = ("127.0.0.1", 5052)

for i in range(100):
    data = i
    print(data);
    sock.sendto(str.encode(str(data)), serverAddressPort)
    time.sleep(1) 
