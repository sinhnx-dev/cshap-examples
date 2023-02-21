using SimpleUdp;

UdpUtil s = new UdpUtil();
s.Server("127.0.0.1", 33333);

UdpUtil c = new UdpUtil();
c.Client("127.0.0.1", 33333);
c.Send("UDP TEST nguyễn xuân sinh!");